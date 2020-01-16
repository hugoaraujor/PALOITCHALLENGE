using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PALOITChallenge.Models
{

    public class HospitalRootObject
    {
     
        [JsonProperty("hospitals")]
        public List<Hospital> hospitals { get; set; }
        [JsonProperty("_links")]
        public Links _links { get; set; }
        [JsonProperty("page")]
        public Page page { get; set; }


    }
    
    public class Self
    {
        public string href { get; set; }
    }

    public class NextHospital : Next { }
    public class Links : WelcomeLinks { }
    public class HospitalPage : Page { }


}