using PatientInfoAPI.Model;

namespace PatientInfoAPI.BussinessLayer.Interface
{
    public interface IPickList
    {
        public List<DiseaseInfo> GetAllDiseaseName();
        public List<NCD> GetAllNCDName();
        public List<Allergy> GetAllergies();
    }
}
