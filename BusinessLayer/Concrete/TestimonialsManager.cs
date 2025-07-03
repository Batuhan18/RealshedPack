using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialsManager : ITestimonialService
    {
        private readonly ITestimonialsDal _testimonialsDal;

        public TestimonialsManager(ITestimonialsDal testimonialsDal)
        {
            _testimonialsDal = testimonialsDal;
        }

        public void TAdd(Testimonials entity)
        {
            _testimonialsDal.Add(entity);
        }

        public void TDelete(int id)
        {
            _testimonialsDal.Delete(id);
        }

        public Testimonials TGetById(int id)
        {
            return _testimonialsDal.GetById(id);
        }

        public List<Testimonials> TGetListAll()
        {
            return _testimonialsDal.GetAllList();
        }

        public void TUpdate(Testimonials entity)
        {
            _testimonialsDal.Update(entity);
        }
    }
}
