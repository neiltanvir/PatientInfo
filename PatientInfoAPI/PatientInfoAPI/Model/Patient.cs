using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PatientInfoAPI.Model
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PId { get; set; }
        [MaxLength(30)]
        public string? Name { get; set; }
        public bool? Epilepcy { get; set; }
        [ForeignKey("DId")]
        public int? DId { get; set; }
        public ICollection<NCD_Details> NCDDetails { get; set; } = default!;
        public ICollection<Allergies_Details> AllergiesDetails { get; set; } = default!;
    }
}
