using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PatientInfoAPI.Model
{
    public class Allergies_Details
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("PId")]
        public int PatientId { get; set; }
        [ForeignKey("AId")]
        public int AllergyId { get; set; }
        public virtual Patient? Patient { get; set; }
    }
}
