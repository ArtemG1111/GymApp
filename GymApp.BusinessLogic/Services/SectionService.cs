

using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Data.Models;
using GymApp.DataAccess.Interfaces;

namespace GymApp.BusinessLogic.Services
{
    public class SectionService : ISectionService
    {
        private readonly ISectionRepository _sectionRepository;
        public SectionService(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }
        public void AddSection(Section section)
        {
            _sectionRepository.AddSection(section);
        }
        public void DeleteSection(int id)
        {
            _sectionRepository.DeleteSection(id);
        }
        public void UpdateSection(Section section)
        {
            _sectionRepository.UpdateSection(section);
        }
        public List<Section> GetSections()
        {
            return _sectionRepository.GetSections();
        }
    }
}
