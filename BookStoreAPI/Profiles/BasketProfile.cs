using AutoMapper;

namespace BookStoreAPI.Profiles
{
    public class BasketProfile : Profile
    {
        public BasketProfile() 
        {
            CreateMap<DTOs.BasketDTO, Entities.Basket>();
            CreateMap<Entities.Basket, DTOs.BasketDTO>();
            CreateMap<DTOs.BasketItemDTO, Entities.BasketItem>();
            CreateMap<Entities.BasketItem, DTOs.BasketItemDTO>();
        }
    }
}
