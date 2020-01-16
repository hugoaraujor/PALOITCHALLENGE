using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PALOITChallenge.Models
{
    public partial class IllnessTableModel : IllnessDesc
    {
        [Key]
        public int IllnessId { get; set; }
        public PainLevels painLevel { get; set; }
    }
}
