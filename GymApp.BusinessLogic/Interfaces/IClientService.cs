

using GymApp.DataAccess.Data.Models;

namespace GymApp.BusinessLogic.Interfaces
{
    public interface IClientService
    {
        void Registration(Client client);
        Client? LogIn(Client client);
        List<Client> GetClients();
        void UpdateClient(Client client);
        void DeleteClient(int id);
    }
}
