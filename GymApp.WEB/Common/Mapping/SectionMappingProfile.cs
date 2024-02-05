using AutoMapper;
using GymApp.DataAccess.Data.Models;
using GymApp.WEB.ViewModels;

namespace GymApp.WEB.Common.Mapping
{
    public class SectionMappingProfile : Profile
    {
        public SectionMappingProfile()
        {
            CreateMap<Section, SectionViewModel>().ReverseMap();
        }
    }
}
