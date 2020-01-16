using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace PALOITChallenge.Models
{
        public partial class Illness
        {
            [JsonProperty("_embedded")]
            public Illnesses Embedded { get; set; }

            [JsonProperty("_links")]
            public WelcomeLinks Links { get; set; }

            [JsonProperty("page")]
            public Page Page { get; set; }
        }

        public partial class Illnesses
        {
            [JsonProperty("illnesses")]
            public IllnessElement[] _illnesses { get; set; }
        }

        public partial class IllnessElement
        {
            [JsonProperty("illness")]
            public IllnessDesc Illness { get; set; }

            [JsonProperty("_links")]
            public IllnessLinks Links { get; set; }
        }

        public partial class IllnessDesc
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("id")]
            public int IllnessId { get; set; }
        }
  
        public partial class IllnessLinks
        {
            [JsonProperty("illnesses")]
            public Next Illnesses { get; set; }

            [JsonProperty("self")]
            public Next Self { get; set; }
        }


      
    

}


