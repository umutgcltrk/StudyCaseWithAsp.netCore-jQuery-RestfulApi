
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudyCase.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StudyCase.Controllers
{
    public class StudyController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync("http://localhost:16831/api/Studies/GetStudies").Result;
            List<Study> studies = null;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                studies = JsonConvert.DeserializeObject<List<Study>>(response.Content.ReadAsStringAsync().Result);
            }
            return View(studies);
        }
        public IActionResult AddStudent()
        {
            return View(new Study());
        }
        [HttpPost]
        public IActionResult AddStudent(Study study)
        {
            HttpClient httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(study),Encoding.UTF8,"application/json");
            var response = httpClient.PostAsync("http://localhost:16831/api/Studies/", content).Result;

            if(response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult StudyEdit(int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = httpClient.GetAsync($"http://localhost:16831/api/Studies/{id}").Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var study = JsonConvert.DeserializeObject<Study>(response.Content.ReadAsStringAsync().Result);
                return View(study);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult StudyEdit(Study study)
        {
            HttpClient httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(study), Encoding.UTF8, "application/json");
            var response = httpClient.PutAsync($"http://localhost:16831/api/Studies/{study.StudyId}", content).Result;
            return RedirectToAction("Index");
        }

        public IActionResult StudyDelete(int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = httpClient.DeleteAsync($"http://localhost:16831/api/Studies/{id}").Result;
            return RedirectToAction("Index");
        }
    }
}
