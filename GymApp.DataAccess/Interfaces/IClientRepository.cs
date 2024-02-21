

using GymApp.DataAccess.Data.Models;

namespace GymApp.DataAccess.Interfaces
{
    public interface IClientRepository
    {
        void Registration(Client client);
        Client? LogIn(Client client);
        List<Client> GetClients();
        void UpdateClient(Client client);
        void DeleteClient(int id);
    }
}
