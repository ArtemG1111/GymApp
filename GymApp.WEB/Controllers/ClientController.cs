using AutoMapper;
using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Data.Models;
using GymApp.WEB.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.WEB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;
        private readonly UserManager<Client> _clientManager;
        private readonly SignInManager<Client> _signInManager;
        private readonly ILogger<ClientController> _logger;
        public ClientController(IClientService clientService, IMapper mapper, SignInManager<Client> signInManager
            ,UserManager<Client> clientManager, ILogger<ClientController> logger)
        {
            _clientService = clientService;
            _mapper = mapper;
            _signInManager = signInManager;
            _clientManager = clientManager;
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> Registration(RegisterClientRequest client)
        {
            var identityUser = _mapper.Map<Client>(client);

            var registratinResult = await _clientManager.CreateAsync(identityUser, client.Password);

            if(!registratinResult.Succeeded)
            {
                _logger.LogError("Registration failed");
                return BadRequest("Invalid login or password");
            }

            await _signInManager.SignInAsync(identityUser, false);
            _logger.LogInformation("Client was successfully added");

            return Ok("Client added");
        }
        [HttpPost("login")]
        public async Task<IActionResult> LogIn(LogInClientRequest client)
        {
            var loginClient = await _clientManager.FindByNameAsync(client.UserName);
            var loginResult = await _signInManager.PasswordSignInAsync(loginClient, client.Password, false, false);
            if(!loginResult.Succeeded)
            {
                _logger.LogError("LogIn failed");
                return BadRequest("Invlid login or password");
            }

            _logger.LogInformation("Client was successfully LogIn");

            return Ok("Client was LogIn");
        }

        [HttpGet]
        [Authorize]
        public List<Client> GetClients()
        {
            return _clientService.GetClients();
        }
        [HttpPost("logout")]
        public async Task<IActionResult> LogOut()
        {
            if (User.Identity!.IsAuthenticated)
            {
                return BadRequest("You can't log out before log in");
            }
            await _signInManager.SignOutAsync();
            return Ok("Successfully log out");
        }

        [HttpPut]
        public IActionResult UpdateClient(RegisterClientRequest client)
        {
            _clientService.UpdateClient(_mapper.Map<Client>(client));
            return Ok("Client was update");
        }
        [HttpDelete]
        public IActionResult DeleteClient(int id)
        {
            _clientService.DeleteClient(id);
            return Ok("Client deleted");
        }
    }
}
