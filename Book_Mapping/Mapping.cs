using AutoMapper;
using BOOK_STORE_PORTAL_Project_.Dto;
using BOOK_STORE_PORTAL_Project_.Models;

namespace BOOK_STORE_PORTAL_Project_.Book_Mapping
{
    public class Mapping : Profile
    {
        public Mapping() 
        {
            CreateMap<Store, CreateStoreDto>().ReverseMap();
            CreateMap<Store, ResponseStoreDto>().ReverseMap();
            CreateMap<Store, UpdateStoreDto>().ReverseMap();    
        }

        
    }
}
