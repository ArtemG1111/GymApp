using AutoMapper;
using GymApp.DataAccess.Data.Models;
using GymApp.WEB.ViewModels;

namespace GymApp.WEB.Common.Mapping
{
    public class FinancialOperationMappingProfile : Profile
    {
        public FinancialOperationMappingProfile()
        {
            CreateMap<FinancialOperation, FinancialOperationViewModel>().ReverseMap();
        }
    }
}
