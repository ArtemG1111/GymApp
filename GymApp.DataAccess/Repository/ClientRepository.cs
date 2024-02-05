

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
            _dbContext.Add(client);
            _dbContext.SaveChanges();
        }
        public List<Client> GetClients()
        {
            return _dbContext.Users.ToList();
        }
        public void UpdateClient(Client client)
        {
            _dbContext.Attach(client);
            _dbContext.SaveChanges();
        }
        public void DeleteClient(int id)
        {
            _dbContext.Remove(id);
            _dbContext.SaveChanges();
        }
    }
}
