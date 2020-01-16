using PALOITChallenge.Models;
using System.ComponentModel.DataAnnotations;

namespace PALOITChallenge.ViewModels
{
    public class HospitalViewModel : HospitalRootObject
    {
       [EnumDataType(typeof(PainLevels))]
        [Required]
        public PainLevels Level { get; set; }
       public PainLevels Illnesspain { get; set; }
      
    }
   

}
