using AutoMapper;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using RealshedPack.Dtos.AboutDto;

namespace RealshedPack.Controllers
{
    public class MainAbout : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public MainAbout(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        public IActionResult AboutList()
        {
            var entityList = _aboutService.TGetListAll();
            var dtoList = _mapper.Map<List<ResultAboutDto>>(entityList);
            return View(dtoList);
        }
    }
}
