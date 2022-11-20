using BusinessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudiesController : ControllerBase
    {
        StudyManager studyManager = new StudyManager(new StudyRepository());
        [HttpGet("[action]")]
        public IActionResult GetStudies()
        {
            var getAllStudy = studyManager.GetAllStudy();
            return Ok(getAllStudy);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudy(int id, Study study)
        {
            studyManager.Update(id,study);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStudy(int id)
        {
            studyManager.Delete(id);
            return NoContent();
        }
        [HttpPost]
        public IActionResult AddStudy(Study study)
        {
            studyManager.Add(study);
            return Created(" ", study);
        }
        [HttpGet("{id}")]
        public IActionResult GetStudyById(int id)
        {
            var getById = studyManager.GetStudyById(id);
            return Ok(getById);
        }
    }
}
