using static PatientInfoUI.Models.ViewModel;

namespace PatientInfoUI.Models
{
    public class ViewModel
    {
        public class Patient
        {
            public int PId { get; set; }
            public string? Name { get; set; }
            public bool? Epilepcy { get; set; }
            public int? DId { get; set; }
            public List<NcdDetails>? NCDDetails { get; set; }
            public List<AllergiesDetails>? AllergiesDetails { get; set; }
        }
        public class NcdDetails
        {
            public int Id { get; set; }
            public int? PatientId { get; set; }
            public int? NCDId { get; set; }
        }

        public class AllergiesDetails
        {
            public int Id { get; set; }
            public int? PatientId { get; set; }
            public int? AllergyId { get; set; }
        }
        public class PatientPerams
        {
            public int PId { get; set; }
            public string? Name { get; set; }
            public int? Disease { get; set; }
            public string? Epilepcy { get; set; }

            public ICollection<NCD_Details>? NCDDetailsList { get; set; }
            public ICollection<Allergy_Details>? AllergiesDetailsList { get; set; }
        }
    }
}
