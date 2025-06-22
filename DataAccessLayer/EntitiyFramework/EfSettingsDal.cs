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
    public class EfSettingsDal : GenericRepository<Settings>, ISettingsDal
    {
        public EfSettingsDal(RealshedPackContext context) : base(context)
        {
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
