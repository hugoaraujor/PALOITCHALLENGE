using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PALOITChallenge.Models
{
    public class WaitingList
    {
        public int patientCount { get; set; }
        [EnumDataType(typeof(PainLevels))]
        public int levelOfPain { get; set; }
        public int averageProcessTime { get; set; }

        public void Add(WaitingList waitingList)
        {
            throw new NotImplementedException();
        }
    }
}
