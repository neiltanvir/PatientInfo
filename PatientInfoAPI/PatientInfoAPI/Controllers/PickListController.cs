using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientInfoAPI.BussinessLayer.Interface;
using PatientInfoAPI.Model;

namespace PatientInfoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PickListController : Controller
    {
        private IPickList _pickList;
        public PickListController(IPickList pickList)
        {
            _pickList = pickList;
        }
        [HttpGet]
        [Route("GetAllDiseaseName")]
        public List<DiseaseInfo> GetAllDiseaseName()
        {
            var list = _pickList.GetAllDiseaseName().ToList();
            return list;
        }
        [HttpGet]
        [Route("GetAllNCDList")]
        public List<NCD> GetAllNCDList()
        {

            var ncdLIst = _pickList.GetAllNCDName().ToList();
            return ncdLIst;
        }
        [HttpGet]
        [Route("GetAllAllergyList")]
        public List<Allergy> GetAllAllergyList()
        {
            var ncdLIst = _pickList.GetAllergies().ToList();
            return ncdLIst;
        }
    }
}
