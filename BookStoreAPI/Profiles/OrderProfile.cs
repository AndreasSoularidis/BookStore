using AutoMapper;
using System.Collections.Generic;

namespace BookStoreAPI.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile() 
        {
            CreateMap<DTOs.OrderDTO, Entities.Order>();
            CreateMap<Entities.Order, DTOs.OrderDTO>();
            CreateMap<IEnumerable<Entities.Order>, List<DTOs.OrderDTO>>();
            CreateMap<List<DTOs.OrderDTO>, IEnumerable <Entities.Order>>();
        }
    }
}
