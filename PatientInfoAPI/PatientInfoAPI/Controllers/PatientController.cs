using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientInfoAPI.BussinessLayer.Interface;
using PatientInfoAPI.Model;

namespace PatientInfoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : Controller
    {
        private IPatient _patient;
        public PatientController(IPatient patient)
        {
            _patient = patient;
        }
        [HttpPost]
        [Route("Create")]
        public int Create(Patient patient)
        {
            _patient.Create(patient);
            return patient.PId;
        }
        [HttpPost]
        [Route("GetById")]
        public Patient GetById(int id)
        {
            var patient = _patient.GetById(id);
            return patient;

        }
        [HttpGet]
        [Route("GetAllPatients")]
        public List<Patient> GetAllPatients()
        {
            var list = _patient.GetAll();
            return list;
        }
        [HttpPut]
        [Route("UpdatePatient")]
        public int Update(Patient patient)
        {
            var res = _patient.Update(patient);
            return res;
        }
        [HttpDelete]
        [Route("DeletebyId")]
        public int DeletebyId(int id)
        {
            int resId = _patient.DeleteById(id);
            return resId;
        }

    }
}
