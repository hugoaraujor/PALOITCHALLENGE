using System;
using System.Collections.Generic;

namespace PALOITChallenge.Models
{

    public class Hospital
    {
        public string name { get; set; }
        public List<WaitingList> waitingList { get; set; }
        public Location location { get; set; }
        public double waitingTime { get; set; }
        public static void ayudame()
        {

        }
    }
    
    
}
