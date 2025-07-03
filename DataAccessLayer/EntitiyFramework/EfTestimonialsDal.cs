using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntitiyFramework
{
    public class EfTestimonialsDal : GenericRepository<Testimonials>, ITestimonialsDal
    {
        public EfTestimonialsDal(RealshedPackContext context) : base(context)
        {
        }

        public void Delete(int id)
        {
            using (var context = new RealshedPackContext())
            {
                var entity = context.Set<Testimonials>().Find(id);
                if (entity != null)
                {
                    context.Set<Testimonials>().Remove(entity);
                    context.SaveChanges();
                }
            }
        }
    }
}
