using AutoMapper;
using EntityLayer.Entities;
using RealshedPack.Dtos.SettingsDto;

namespace RealshedPack.Mapping
{
    public class SettingsMapping : Profile
    {
        public SettingsMapping()
        {
            CreateMap<Settings, CreateSettingDto>().ReverseMap();
            CreateMap<Settings, UpdateSettingDto>().ReverseMap();
            CreateMap<Settings, ResultSettingDto>().ReverseMap();
            CreateMap<Settings, GetSettingDto>().ReverseMap();
        }
    }
}
