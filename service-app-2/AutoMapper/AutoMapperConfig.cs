using AutoMapper;
using service_app_2.Dtos;
using service_app_2.Entities;

namespace service_app_2.AutomapperConfig
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Produto, ProdutoDto>().ReverseMap();
                
        }   
    }
}
