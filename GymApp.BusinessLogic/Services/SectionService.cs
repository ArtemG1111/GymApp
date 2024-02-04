

using GymApp.BusinessLogic.Interfaces;

namespace GymApp.BusinessLogic.Services
{
    public class SectionService : ISectionService
    {
        private readonly ISectionService _sectionService;
        public SectionService(ISectionService sectionService)
        {
            _sectionService = sectionService;
        }
    }
}
