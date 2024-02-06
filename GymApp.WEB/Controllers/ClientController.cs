using AutoMapper;
using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Data.Models;
using GymApp.WEB.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.WEB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;
        public ClientController(IClientService clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult AddClient(ClientViewModel client)
        {
            _clientService.AddClient(_mapper.Map<Client>(client));
            return Ok("Client added");
        }
        [HttpGet]
        public IActionResult GetClients()
        {
            _clientService.GetClients();
            return Ok("Clients received");
        }
        [HttpPut]
        public IActionResult UpdateClient(ClientViewModel client)
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
