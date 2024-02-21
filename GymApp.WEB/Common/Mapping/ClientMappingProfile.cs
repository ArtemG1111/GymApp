using AutoMapper;
using GymApp.DataAccess.Data.Models;
using GymApp.WEB.ViewModels;

namespace GymApp.WEB.Common.Mapping
{
    public class ClientMappingProfile : Profile
    {
        public ClientMappingProfile()
        {
            CreateMap<Client, RegisterClientRequest>().ReverseMap();
            CreateMap<Client, LogInClientRequest>().ReverseMap();
        }
    }
}
