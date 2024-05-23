using PatientInfoAPI.BussinessLayer.Interface;
using PatientInfoAPI.Data;
using PatientInfoAPI.Model;

namespace PatientInfoAPI.BussinessLayer.Repository
{
    public class PatientRepository : IPatient
    {
        private readonly AppDbContext _context;
        public PatientRepository(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public int Create(Patient patient)
        {
            try
            {
                if (patient == null)
                {
                    return 0;
                }
                else
                {
                    _context.Patients.Add(patient);
                    _context.SaveChanges();
                    return patient.PId;
                }

                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Patient GetById(int id)
        {
            try
            {
                var patient = _context.Patients.Where(x => x.PId == id).FirstOrDefault();
                return patient;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Patient> GetAll()
        {
            try
            {
                var list = _context.Patients.ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public int DeleteById(int id)
        {
            try
            {
                var result = 0;
                var patient = _context.Patients.Where(x => x.PId == id).FirstOrDefault();
                if (patient != null)
                {
                    _context.Patients.Remove(patient);
                    _context.SaveChanges();
                    result = id;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(Patient patient)
        {
            try
            {
                var result = 0;
                var patientInfo = _context.Patients.Where(x => x.PId == patient.PId).FirstOrDefault();
                if (patientInfo != null)
                {
                    patientInfo.PId = patient.PId;
                    patientInfo.DId = patient.DId;
                    patientInfo.Name = patient.Name;
                    patientInfo.AllergiesDetails = patient.AllergiesDetails;
                    patientInfo.NCDDetails = patient.NCDDetails;
                    _context.SaveChanges();
                    result = patient.PId;
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
