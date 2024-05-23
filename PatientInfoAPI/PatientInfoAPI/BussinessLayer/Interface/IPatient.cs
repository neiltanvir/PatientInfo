using PatientInfoAPI.Model;

namespace PatientInfoAPI.BussinessLayer.Interface
{
    public interface IPatient
    {
        public int Create(Patient patient);
        public Patient GetById(int id);
        public List<Patient> GetAll();
        public int DeleteById(int id);
        public int Update(Patient patient);
    }
}
