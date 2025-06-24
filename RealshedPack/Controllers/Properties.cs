using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RealshedPack.Dtos.PropertiesDto;
using RealshedPack.Models;

namespace RealshedPack.Controllers
{
    public class Properties : Controller
    {
        private readonly IPropertiesService _propertiesService;
        private readonly IMapper _mapper;
        private readonly RealshedPackContext _realshedPackContext;

        public Properties(IPropertiesService propertiesService, IMapper mapper, RealshedPackContext realshedPackContext)
        {
            _propertiesService = propertiesService;
            _mapper = mapper;
            _realshedPackContext = realshedPackContext;
        }

        [HttpGet]
        public IActionResult PropertiesList()
        {
            var entityList = _propertiesService.TGetListAll();
            var dtoList = _mapper.Map<List<ResultPropertiesDto>>(entityList);
            return View(dtoList);
        }

        [HttpGet]
        public IActionResult CreateProperties()
        {
            var agents = _realshedPackContext.Agents
            .Select(a => new AgentOption
            {
                AgentId = a.AgentsId,
                FullName = a.AgentName + " " + a.AgentSurname
            }).ToList();

            ViewBag.AgentOptions = new SelectList(agents, "Id", "FullName");

            return View();
        }

        [HttpPost]
        public IActionResult CreateProperties(CreatePropertiesDto createPropertiesDto)
        {
            var list = _mapper.Map<EntityLayer.Entities.Properties>(createPropertiesDto);
            _propertiesService.TAdd(list);
            return RedirectToAction("PropertiesList");
        }

        public IActionResult DeleteProperties(int id)
        {
            _propertiesService.TDelete(id);
            return RedirectToAction("PropertiesList");
        }

        [HttpGet]
        public IActionResult UpdateProperties(int id)
        {
            var proEntity = _propertiesService.TGetById(id);
            var updateDto = _mapper.Map<UpdatePropertiesDto>(proEntity);
            return View(updateDto);
        }

        [HttpPost]
        public IActionResult UpdateProperties(UpdatePropertiesDto updatePropertiesDto)
        {
            var pro = _mapper.Map<EntityLayer.Entities.Properties>(updatePropertiesDto);
            _propertiesService.TUpdate(pro);
            return RedirectToAction("PropertiesList");
        }
    }
}
