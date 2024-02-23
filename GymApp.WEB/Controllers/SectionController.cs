using AutoMapper;
using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Data.Models;
using GymApp.WEB.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.WEB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SectionController : ControllerBase
    {
        private readonly ISectionService _sectionService;
        private readonly IMapper _mapper;
        public SectionController(ISectionService sectionService, IMapper mapper)
        {
            _sectionService = sectionService;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult AddSection(SectionViewModel viewSection)
        {
            var mapResult = _mapper.Map<Section>(viewSection);

            _sectionService.AddSection(mapResult);
            return Ok("Section was added");
        }
        [HttpGet]
        public IActionResult GetSections()
        {
            var result = _sectionService.GetSections();
            return Ok(result);      
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
        [HttpPost("addSectionToSubscription")]
        public IActionResult AddSectionToSubscription(AddSectionToSubscriptionRequest request)
        {
            _sectionService.AddSectionToSubscription(request.SectionId, request.SubscriptionId);

            return Ok("Section was added to Subscription");
        }
    }
}
