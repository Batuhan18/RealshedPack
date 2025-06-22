using AutoMapper;
using EntityLayer.Entities;
using RealshedPack.Dtos.AmenitiesDto;

namespace RealshedPack.Mapping
{
    public class AmenitiesMapping:Profile
    {
        public AmenitiesMapping()
        {
            CreateMap<Amenities, ResultAmenitiesDto>().ReverseMap();
            CreateMap<Amenities, GetAmenitiesDto>().ReverseMap();
            CreateMap<Amenities, UpdateAmenitiesDto>().ReverseMap();
            CreateMap<Amenities, CreateAmenitiesDto>().ReverseMap();
            CreateMap<Amenities, CreateAmenitiesDto>().ReverseMap();
            CreateMap<Amenities, CreateAmenitiesDto>().ReverseMap();
        }
    }
}
