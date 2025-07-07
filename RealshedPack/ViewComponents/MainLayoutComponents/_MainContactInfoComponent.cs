using AutoMapper;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using RealshedPack.Dtos.AgentsDto;
using RealshedPack.Dtos.Contact_MessagesDto;

namespace RealshedPack.ViewComponents.MainLayoutComponents
{
    public class _MainContactInfoComponent : ViewComponent
    {
        private readonly IAgentsService _agentsService;
        private readonly IMapper _mapper;

        public _MainContactInfoComponent(IAgentsService agentsService, IMapper mapper)
        {
            _agentsService = agentsService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var entityList = _agentsService.TGetListAll();
            var dtoList = _mapper.Map<List<ResultAgentDto>>(entityList);
            return View(dtoList);
        }
    }
}
