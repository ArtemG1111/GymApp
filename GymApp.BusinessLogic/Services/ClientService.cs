

using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Data;
using GymApp.DataAccess.Data.Models;
using GymApp.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GymApp.BusinessLogic.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly GymAppContext _dbContext;
        public ClientService(IClientRepository clientRepository, GymAppContext dbContext)
        {
            _clientRepository = clientRepository;
            _dbContext = dbContext;
        }
        public void Registration(Client client)
        {
            _clientRepository.Registration(client);
        }
        public Client LogIn(Client client)
        {
            return _clientRepository.LogIn(client);
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
        public void ExpiredSubscription()
        {
            var clients = _dbContext.Clients.Include(s => s.Subscription).Where(h => h.HasPaidForSubscription).ToList();
            
            foreach (var c in clients)
            {
                if (c.Balance >= c.Subscription.Price)
                {
                    c.Balance -= c.Subscription.Price;

                }
                c.HasPaidForSubscription = false;
            }
            _dbContext.SaveChanges();
        }                    
    }
}
