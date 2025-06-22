using AutoMapper;
using EntityLayer.Entities;
using RealshedPack.Dtos.AgentsDto;

namespace RealshedPack.Mapping
{
    public class AgentsMapping : Profile
    {
        public AgentsMapping()
        {
            CreateMap<Agents, CreateAgentDto>().ReverseMap();
            CreateMap<Agents, GetAgentDto>().ReverseMap();
            CreateMap<Agents, UpdateAgentDto>().ReverseMap();
            CreateMap<Agents, ResultAgentDto>().ReverseMap();
        }
    }
}
