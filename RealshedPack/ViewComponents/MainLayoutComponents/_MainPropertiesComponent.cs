using AutoMapper;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using RealshedPack.Dtos.PropertiesDto;

namespace RealshedPack.ViewComponents.MainLayoutComponents
{
    public class _MainPropertiesComponent : ViewComponent
    {
        private readonly IPropertiesService _propertiesService;
        private readonly IMapper _mapper;

        public _MainPropertiesComponent(IPropertiesService propertiesService, IMapper mapper)
        {
            _propertiesService = propertiesService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var entityList = _propertiesService.TGetListAll();
            var dtoList = _mapper.Map<List<ResultPropertiesDto>>(entityList);
            return View(dtoList);
        }
    }
}
