

using GymApp.DataAccess.Data;
using GymApp.DataAccess.Data.Models;
using GymApp.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GymApp.DataAccess.Repository
{
    public class SectionRepository : ISectionRepository
    {
        private readonly GymAppContext _dbContext;
        public SectionRepository(GymAppContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddSection(Section section)
        {
            _dbContext.Sections.Add(section);
            _dbContext.SaveChanges();
        }
        public void DeleteSection(int id)
        {
            Section? section = _dbContext.Sections.Find(id);
            if (section == null)
            {
                throw new Exception($"Section with id {id} not found");
            }
            _dbContext.Remove(section);
            _dbContext.SaveChanges();
        }
        public void UpdateSection(Section section)
        {
            _dbContext.Sections.Attach(section);
            _dbContext.SaveChanges();
        }
        public List<Section> GetSections()
        {
            return _dbContext.Sections.ToList();
        }
    }
}
