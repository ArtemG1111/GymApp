
using GymApp.DataAccess.Data;
using GymApp.DataAccess.Data.Models;
using GymApp.DataAccess.Interfaces;

namespace GymApp.DataAccess.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly GymAppContext _dbContext;
        public ClientRepository(GymAppContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddClient(Client client)
        {
            _dbContext.Clients.Add(client);
            _dbContext.SaveChanges();
        }
        public List<Client> GetClients()
        {
            return _dbContext.Clients.ToList();
        }
        public void UpdateClient(Client client)
        {
            _dbContext.Attach(client);
            _dbContext.SaveChanges();
        }
        public void DeleteClient(int id)
        {
            Client? client = _dbContext.Clients.Find(id);
            if (client == null)
            {
                throw new Exception($"Client with id {id} not found");
            }
            _dbContext.Remove(client);
            _dbContext.SaveChanges();
        }
    }
}
