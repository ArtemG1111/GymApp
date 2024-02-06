

using GymApp.DataAccess.Data.Models;

namespace GymApp.DataAccess.Interfaces
{
    public interface ISectionRepository
    {
        void AddSection(Section section);
        void DeleteSection(int id);
        void UpdateSection(Section section);
        List<Section> GetSections();
    }
}
