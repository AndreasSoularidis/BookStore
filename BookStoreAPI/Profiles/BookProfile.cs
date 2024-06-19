using AutoMapper;

namespace BookStoreAPI.Profiles
{
    public class BookProfile : Profile
    {
       public BookProfile() 
        {
            CreateMap<Entities.Book, DTOs.BookDTO>();
            CreateMap<DTOs.InsertNewBookDTO, Entities.Book>();
        }

    }
}
