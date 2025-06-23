using AutoMapper;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using RealshedPack.Dtos.PropertiesDto;

namespace RealshedPack.Controllers
{
    public class Properties : Controller
    {
        private readonly IPropertiesService _propertiesService;
        private readonly IMapper _mapper;

        public Properties(IPropertiesService propertiesService, IMapper mapper)
        {
            _propertiesService = propertiesService;
            _mapper = mapper;
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
