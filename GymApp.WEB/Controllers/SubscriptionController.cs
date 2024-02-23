using AutoMapper;
using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Data.Models;
using GymApp.WEB.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.WEB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionController : ControllerBase
    {
        private readonly ISubscriptionService _subscriptionService;
        private readonly IMapper _mapper;
        private readonly ILogger<SubscriptionController> _logger;
        public SubscriptionController(ISubscriptionService subscriptionService, IMapper mapper, 
            ILogger<SubscriptionController> logger)
        {
            _subscriptionService = subscriptionService;
            _mapper = mapper;
            _logger = logger;            
        }
        [HttpPost]
        public async Task<IActionResult> AddSubscription(SubscriptionViewModel viewSubscription)
        {
            var mapResult = _mapper.Map<Subscription>(viewSubscription);

            _subscriptionService.AddSubscription(mapResult);

            return Ok();
        }
        [HttpGet]
        public IActionResult GetSubscriptions()
        {
            var result = _subscriptionService.GetSubscriptions();

            return Ok(result);
        }
        [HttpPost("addClientsToSubscription")]
        [Authorize]
        public async Task<IActionResult> AddClientsToSubscription(AddClientsToSubscriptionRequest request)
        {
            await _subscriptionService.AddClientsToSubscription(request.SubscriptionId, User.Identity.Name);

            return Ok();
        }
    }
}
