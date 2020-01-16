using haljson;
using PALOITChallenge.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PALOITChallenge
{
    public class Services
    {

        static HttpClient client = new HttpClient();
        public static async Task<T> GetData<T>(string path) where T : class, new()
        {
            T data = new T();
            var response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                data = HALJSonDeserializer.GetAndParse<T>(path);
            }
            return data;
        }

        public  static async Task<HospitalRootObject> GetHospitals(string path,PainLevels? level=null)
        {
            var data = await GetData<HospitalRootObject>(path);
            if (level != null) { 
                foreach (var h in data.hospitals)
                {
                    h.waitingList = FilterList(h.waitingList, level.Value);
                }
                addWaitingTimes(data);
            }
            data.hospitals = SortBy(data.hospitals, p => p.waitingTime);
            return data;
        }
        public static List<T> SortBy<T>(List<T> toSort, Func<T, IComparable> getProp)
        {
            if (toSort != null && toSort.Count > 0)
            {
                return toSort
                    .OrderBy(x => getProp(x))
                    .ToList();
            }
            return null;
        }
        
        private static void addWaitingTimes(HospitalRootObject data)
        {
          
                foreach (var h in data.hospitals)
                {
                    h.waitingTime = WaitTimeCalculator(h.waitingList);
                }
          
        }

        private static List<WaitingList> FilterList(List<WaitingList> waitingList, PainLevels level)
        {
                return waitingList.Where(w => w.levelOfPain == ((int)level)).ToList();

        }
        private static double WaitTimeCalculator(List<WaitingList> waitingList)
        {
           return Convert.ToDouble(waitingList.First().patientCount * waitingList.First().averageProcessTime);
        }
        public static  List<IllnessTableModel> GetIllness(ZombiesData context)
        {
            return context.Diseasses.ToList();

        }
        public async static Task PopulateIllness(ZombiesData context, string illnesspath)
        {
             if (!context.Diseasses.Any())
            {
                var Diseases = await Services.GetData<Illnesses>(illnesspath);
                foreach (IllnessElement i in Diseases._illnesses)
                {
                    context.Diseasses.Add(new IllnessTableModel() { IllnessId = i.Illness.IllnessId, Name = i.Illness.Name, painLevel = 0 });

                }
                context.SaveChanges();
            }
        }
        
    
    }
}
