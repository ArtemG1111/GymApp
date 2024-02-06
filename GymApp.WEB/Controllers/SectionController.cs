using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.WEB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SectionController : ControllerBase
    {
        private readonly ISectionService _sectionService;
        public SectionController(ISectionService sectionService)
        {
            _sectionService = sectionService;
        }
        [HttpPost]
        public IActionResult AddSection(Section section)
        {
            _sectionService.AddSection(section);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetSections()
        {
            _sectionService.GetSections();
            return Ok();      
        }
        [HttpPut]
        public IActionResult UpdateSection(Section section)
        {
            _sectionService.UpdateSection(section);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSection(int id)
        {
            _sectionService.DeleteSection(id);
            return Ok();
        }
    }
}
