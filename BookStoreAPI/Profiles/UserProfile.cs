using AutoMapper;

namespace BookStoreAPI.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<Entities.User, DTOs.UserDTO>();
            CreateMap<DTOs.InsertNewUserDTO, Entities.User>();
            CreateMap<DTOs.UpdateUserDTO, Entities.User>();
        }
    }
}
