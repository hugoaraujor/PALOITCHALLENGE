using System.ComponentModel.DataAnnotations;
namespace PALOITChallenge.Models
{
    public class Patient
    {[Key]
        public int Id { get; set; }
        public int IllnessId { get; set; }
        public string HospitalName { get; set; }

        
    }
}
