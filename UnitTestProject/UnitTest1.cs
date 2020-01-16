using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContext;
        [TestMethod]
        public async System.Threading.Tasks.Task TestIllnessLoad()
        {
            var illnesspath = "http://dmmw-api.australiaeast.cloudapp.azure.com:8080/illnesses";
            var records = await  PALOITChallenge.Services.GetData<PALOITChallenge.Models.Illnesses>(illnesspath);
            if (records._illnesses == null)
                Assert.Fail();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestHospitalLoad()
        {      
            var hospitalpath = "http://dmmw-api.australiaeast.cloudapp.azure.com:8080/hospitals";
            var records=await PALOITChallenge.Services.GetData<PALOITChallenge.Models.HospitalRootObject> (hospitalpath);
            if (records.hospitals==null)
                Assert.Fail();
        }
        [TestMethod]
        public  void TestCalculatesWaitTime()
        {
            var WaitLst = new List<PALOITChallenge.Models.WaitingList>();
            WaitLst.Add(new PALOITChallenge.Models.WaitingList() { patientCount=7, levelOfPain = 3, averageProcessTime = 25 });
                Assert.AreEqual(WaitLst.First().patientCount * WaitLst.First().averageProcessTime,175);
           
        }
        class testPupil
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        [TestMethod]
        public void SortaList()
        {
            var toSort = new List<testPupil>();
            toSort.Add(new testPupil() { Age = 48, Name = "Charles" });
            toSort.Add(new testPupil() { Age = 10, Name = "Amanda" });
            toSort.Add(new testPupil() { Age = 30, Name = "Martin" });
            Func<testPupil, IComparable> prop = (p => p.Age);

            

            if (toSort != null && toSort.Count > 0)
            {
                toSort=toSort.OrderBy(x=>prop(x)).ToList();
            }

            if (!(toSort.FirstOrDefault().Age==10))
                Assert.Fail("Error Sorting List provided");
            
        }


    }
}
