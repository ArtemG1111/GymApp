using GymApp.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.WEB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinancialOperationController : ControllerBase
    {
        private readonly IFinancialOperationService _financialOperationService;
        public FinancialOperationController(IFinancialOperationService financialOperationService)
        {
            _financialOperationService = financialOperationService;
        }
        [HttpGet]
        public IActionResult GetOperations()
        {
            _financialOperationService.GetOperations();
            return Ok();
        }
    }
}
