

using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Data.Models;
using GymApp.DataAccess.Interfaces;

namespace GymApp.BusinessLogic.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public void AddClient(Client client)
        {
            _clientRepository.AddClient(client);
        }
        public List<Client> GetClients()
        {
            return _clientRepository.GetClients();
        }
        public void UpdateClient(Client client)
        {
            _clientRepository.UpdateClient(client);
        }
        public void DeleteClient(int id)
        {
            _clientRepository.DeleteClient(id);
        }
    }
}
