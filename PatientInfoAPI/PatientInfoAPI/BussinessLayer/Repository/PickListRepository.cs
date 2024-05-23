using PatientInfoAPI.BussinessLayer.Interface;
using PatientInfoAPI.Data;
using PatientInfoAPI.Model;

namespace PatientInfoAPI.BussinessLayer.Repository
{
    public class PickListRepository : IPickList
    {
        private readonly AppDbContext _context;
        public PickListRepository(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public List<DiseaseInfo> GetAllDiseaseName()
        {
            try
            {
                var diseaseList = _context.DiseaseInfo.ToList();
                return diseaseList;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<NCD> GetAllNCDName()
        {
            try
            {
                var ncdList = _context.NCDs.ToList();
                return ncdList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Allergy> GetAllergies()
        {
            try
            {
                var allergyList = _context.Allergies.ToList();
                return allergyList;
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
