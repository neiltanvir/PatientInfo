using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PatientInfoUI.Service;
using static PatientInfoUI.Models.ViewModel;

namespace PatientInfoUI.Controllers
{
    public class PatientController : Controller
    {

        public IActionResult Create()
        {
            PickList dropDown = new PickList();
            var list = dropDown.GetAllDiseaseName();

            List<SelectListItem> items = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Yes",  Value= "1" },
                new SelectListItem { Text = "No", Value = "0" },

            };
            ViewBag.Epilepsy = items;
            var ncdList = dropDown.GetAllNCD();
            ncdList.Select(option => new SelectListItem
            {
                Value = option.NId.ToString(),
                Text = option.Name
            }).ToList();
            ViewBag.NcdList = ncdList;
            var allergy = dropDown.GetAllAllergy();
            allergy.Select(option => new SelectListItem
            {
                Value = option.AId.ToString(),
                Text = option.Name
            }).ToList();
            ViewBag.AlleryList = allergy;
            return View(list);
        }
        [HttpPost]
        public IActionResult Post([FromBody] PatientPerams perams)
        {
            try
            {
                List<NcdDetails> ncdDetails = new List<NcdDetails>();
                List<AllergiesDetails> allergiesDetailsList = new List<AllergiesDetails>();
                bool epilepsy = false;
                if (perams != null)
                {
                    epilepsy = Convert.ToBoolean(Convert.ToInt32(perams.Epilepcy));
                    foreach (var item in perams.NCDDetailsList)
                    {
                        NcdDetails ncdDetailsForList = new NcdDetails
                        {
                            Id = 0,
                            PatientId = 0,
                            NCDId = item.Id

                        };
                        ncdDetails.Add(ncdDetailsForList);
                    }
                    foreach (var item in perams.AllergiesDetailsList)
                    {

                        AllergiesDetails allergiesDetailsForList = new AllergiesDetails
                        {
                            Id = 0,
                            PatientId = 0,
                            AllergyId = item.Id
                        };
                        allergiesDetailsList.Add(allergiesDetailsForList);
                    }
                }


                Patient dataToApi = new Patient
                {
                    Name = perams.Name,
                    DId = perams.Disease,
                    Epilepcy = epilepsy,
                    NCDDetails = ncdDetails,
                    AllergiesDetails = allergiesDetailsList
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BaseUrl.BASE_URL);
                string newUrl = client.BaseAddress + "api/Patient/Create";
                var responseTask = client.PostAsJsonAsync(newUrl, dataToApi).Result;
                if (responseTask.IsSuccessStatusCode)
                {
                    return StatusCode((int)responseTask.StatusCode);
                }
                else
                {
                    return StatusCode((int)responseTask.StatusCode);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
