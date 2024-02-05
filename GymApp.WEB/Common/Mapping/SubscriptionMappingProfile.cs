using AutoMapper;
using GymApp.DataAccess.Data.Models;
using GymApp.WEB.ViewModels;

namespace GymApp.WEB.Common.Mapping
{
    public class SubscriptionMappingProfile : Profile
    {
        public SubscriptionMappingProfile()
        {
            CreateMap<Subscription, SubscriptionViewModel>().ReverseMap();
        }
    }
}
