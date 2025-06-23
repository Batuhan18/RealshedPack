using AutoMapper;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using RealshedPack.Dtos.AgentsDto;

namespace RealshedPack.Controllers
{
    public class Agents : Controller
    {
        private readonly IAgentsService _agentsService;
        private readonly IMapper _mapper;

        public Agents(IAgentsService agentsService, IMapper mapper)
        {
            _agentsService = agentsService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult AgentsList()
        {
            var agentList = _agentsService.TGetListAll();
            var list = _mapper.Map<List<ResultAgentDto>>(agentList);
            return View(list);
        }

        [HttpGet]
        public IActionResult CreateAgents()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAgents(CreateAgentDto createAgentDto)
        {
            var agent = _mapper.Map<EntityLayer.Entities.Agents>(createAgentDto);
            _agentsService.TAdd(agent);
            return RedirectToAction("AgentsList");
        }

        public ActionResult DeleteAgents(int id)
        {
            _agentsService.TDelete(id);
            return RedirectToAction("AgentsList");
        }

        [HttpGet]
        public IActionResult UpdateAgents(int id)
        {
            var agentEntity = _agentsService.TGetById(id);
            var updateDto = _mapper.Map<UpdateAgentDto>(agentEntity);
            return View(updateDto);
        }

        [HttpPost]
        public IActionResult UpdateAgents(UpdateAgentDto updateAgentDto)
        {
            var agent = _mapper.Map<EntityLayer.Entities.Agents>(updateAgentDto);
            _agentsService.TUpdate(agent);
            return RedirectToAction("AgentsList");
        }
    }
}
