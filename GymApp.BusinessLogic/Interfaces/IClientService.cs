

using GymApp.DataAccess.Data.Models;

namespace GymApp.BusinessLogic.Interfaces
{
    public interface IClientService
    {
        void AddClient(Client client);
        List<Client> GetClients();
        void UpdateClient(Client client);
        void DeleteClient(int id);
    }
}
