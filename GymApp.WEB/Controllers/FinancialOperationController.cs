using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.WEB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class FinancialOperationController : ControllerBase
    {
        private readonly IFinancialOperationService _financialOperationService;
        private readonly UserManager<Client> _userManager;
        private readonly ILogger<FinancialOperationController> _logger;
        public FinancialOperationController(IFinancialOperationService financialOperationService,
            UserManager<Client> userManager, ILogger<FinancialOperationController> logger)
        {
            _financialOperationService = financialOperationService;
            _userManager = userManager;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> GetFinOperations(string userName)
        {
            await _financialOperationService.GetFinOperations(User.Identity.Name);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> AddFunds(decimal amount)
        {
            await _financialOperationService.AddFunds(amount, User.Identity.Name);
            return Ok("Payment successful");
        }
    }
}
