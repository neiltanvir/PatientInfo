using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PatientInfoAPI.Model
{
    public class DiseaseInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DId { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
    }
}
