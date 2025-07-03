using AutoMapper;
using EntityLayer.Entities;
using RealshedPack.Dtos.TestimonialDto;

namespace RealshedPack.Mapping
{
    public class TestimonialMapping:Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonials, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonials, GetTestimonialDto>().ReverseMap();
            CreateMap<Testimonials, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonials, UpdateTestimonialDto>().ReverseMap();
        }
    }
}
