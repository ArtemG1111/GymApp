

using GymApp.DataAccess.Data.Models;

namespace GymApp.BusinessLogic.Interfaces
{
    public interface ISectionService
    {
        void AddSection(Section section);
        void DeleteSection(int id);
        void UpdateSection(Section section);
        List<Section> GetSections();
        void AddSectionToSubscription(int sectionId, int subscriptionId);
    }
}
