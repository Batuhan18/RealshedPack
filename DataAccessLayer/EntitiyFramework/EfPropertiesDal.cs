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
    public class EfPropertiesDal : GenericRepository<Properties>, IPropertiesDal
    {
        private readonly RealshedPackContext _realshedPackContext;
        public EfPropertiesDal(RealshedPackContext context, RealshedPackContext realshedPackContext) : base(context)
        {
            _realshedPackContext = realshedPackContext;
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Properties> GetAllList()
        {
            return _realshedPackContext.Properties
                .Include(p => p.Agents).ToList();
        }


    }
}
