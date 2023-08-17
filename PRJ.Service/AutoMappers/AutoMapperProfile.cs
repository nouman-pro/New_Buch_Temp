


using PRJ.DataAccess.Entities;
using PRJ.Service.Services.User.DTOs;

namespace PRJ.Service.AutoMapper;
public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<User, UserInputDTO>().ReverseMap();
    }
}
