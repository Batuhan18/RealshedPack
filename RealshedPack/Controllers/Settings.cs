using AutoMapper;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using RealshedPack.Dtos.SettingsDto;

namespace RealshedPack.Controllers
{
    public class Settings : Controller
    {
        private readonly ISettingsService _settingsService;
        private readonly IMapper _mapper;

        public Settings(ISettingsService settingsService, IMapper mapper)
        {
            _settingsService = settingsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SettingList()
        {
            var entityList = _settingsService.TGetListAll();
            var maple = _mapper.Map<List<ResultSettingDto>>(entityList);
            return View(maple);
        }

        [HttpGet]
        public IActionResult CreateSettings()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSettings(CreateSettingDto createSettingDto)
        {
            var setting = _mapper.Map<EntityLayer.Entities.Settings>(createSettingDto);
            _settingsService.TUpdate(setting);
            return RedirectToAction("SettingList");
        }

        public IActionResult DeleteSettings(int id)
        {
            _settingsService.TDelete(id);
            return RedirectToAction("SettingList");
        }

        [HttpGet]
        public IActionResult UpdateSettings(int id)
        {
            var entitySetting = _settingsService.TGetById(id);
            var updateEntity = _mapper.Map<UpdateSettingDto>(entitySetting);
            return View(updateEntity);
        }

        [HttpPost]
        public IActionResult UpdateSettings(UpdateSettingDto updateSettingDto)
        {
            var setting = _mapper.Map<EntityLayer.Entities.Settings>(updateSettingDto);
            _settingsService.TUpdate(setting);
            return RedirectToAction("SettingList");
        }
    }
}
