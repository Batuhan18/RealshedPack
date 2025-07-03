using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using RealshedPack.Dtos.TestimonialDto;

namespace RealshedPack.ViewComponents.MainLayoutComponents
{
    public class _MainTestimonialComponent : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public _MainTestimonialComponent(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var entityList = _testimonialService.TGetListAll();
            var dtoList = _mapper.Map<List<ResultTestimonialDto>>(entityList);
            return View(dtoList);
        }
    }
}
