using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using RealshedPack.Dtos.AboutDto;

namespace RealshedPack.Controllers
{
    public class About : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public About(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var entityList = _aboutService.TGetListAll();
            var dtoList = _mapper.Map<List<ResultAboutDto>>(entityList);
            return View(dtoList);
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            var about = _mapper.Map<EntityLayer.Entities.About>(createAboutDto);
            _aboutService.TAdd(about);
            return RedirectToAction("AboutList");

        }

        public IActionResult DeleteAbout(int id)
        {
            _aboutService.TDelete(id);
            return RedirectToAction("AboutList");

        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var aboutEntity = _aboutService.TGetById(id);
            var updateDto = _mapper.Map<UpdateAboutDto>(aboutEntity); 
            return View(updateDto);
        }

        [HttpPost]  
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            var about = _mapper.Map<EntityLayer.Entities.About>(updateAboutDto);
            _aboutService.TUpdate(about);
            return RedirectToAction("AboutList");
        }
    }
}
