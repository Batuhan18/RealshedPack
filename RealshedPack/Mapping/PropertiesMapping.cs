using AutoMapper;
using EntityLayer.Entities;
using RealshedPack.Dtos.PropertiesDto;

namespace RealshedPack.Mapping
{
    public class PropertiesMapping : Profile
    {
        public PropertiesMapping()
        {
            CreateMap<Properties, CreatePropertiesDto>().ReverseMap();
            CreateMap<Properties, UpdatePropertiesDto>().ReverseMap();
            CreateMap<Properties, ResultPropertiesDto>().ReverseMap();
            CreateMap<Properties, GetPropertiesDto>().ReverseMap();
        }
    }
}
