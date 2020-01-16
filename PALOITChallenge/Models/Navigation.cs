using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PALOITChallenge.Models
{

    public partial class Next
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }
    }

    public partial class WelcomeLinks
    {
        [JsonProperty("self")]
        public Self self { get; set; }
        [JsonProperty("next")]
        public Next next { get; set; }
    }

    public partial class Page
    {
        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("totalElements")]
        public long TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public long TotalPages { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }
    }
}
