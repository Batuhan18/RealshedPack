using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntitiyFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(RealshedPackContext context) : base(context)
        {
        }

        public void Delete(int id)
        {
            using (var context = new RealshedPackContext())
            {
                var entity = context.Set<About>().Find(id);
                if (entity != null)
                {
                    context.Set<About>().Remove(entity);
                    context.SaveChanges();
                }
            }
        }
    }
}
