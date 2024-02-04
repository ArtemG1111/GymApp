

using GymApp.DataAccess.Data;
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
    }
}
