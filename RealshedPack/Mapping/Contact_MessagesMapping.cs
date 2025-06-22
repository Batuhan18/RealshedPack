using AutoMapper;
using EntityLayer.Entities;
using RealshedPack.Dtos.Contact_MessagesDto;

namespace RealshedPack.Mapping
{
    public class Contact_MessagesMapping : Profile
    {
        public Contact_MessagesMapping()
        {
            CreateMap<Contact_Messages, ResultContact_MessagesDto>().ReverseMap();
            CreateMap<Contact_Messages, GetContact_MessagesDto>().ReverseMap();
            CreateMap<Contact_Messages, UpdateContact_MessagesDto>().ReverseMap();
            CreateMap<Contact_Messages, CreateContact_MessagesDto>().ReverseMap();
        }
    }
}
