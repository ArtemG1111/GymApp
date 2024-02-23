

using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Data;
using GymApp.DataAccess.Data.Models;
using GymApp.DataAccess.Interfaces;

namespace GymApp.BusinessLogic.Services
{
    public class SectionService : ISectionService
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly GymAppContext _dbContext;
        public SectionService(ISectionRepository sectionRepository, GymAppContext dbContext)
        {
            _sectionRepository = sectionRepository;
            _dbContext = dbContext;
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
        public void AddSectionToSubscription(int sectionId, int subscriptionId)
        {
            var section = _dbContext.Sections.Find(sectionId);

            var subscription = _dbContext.Subscriptions.Find(subscriptionId);

            subscription.Sections.Add(section);

            _dbContext.SaveChanges();
        }
    }
}
