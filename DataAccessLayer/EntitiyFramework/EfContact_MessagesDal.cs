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
    public class EfContact_MessagesDal : GenericRepository<Contact_Messages>, IContact_MessagesDal
    {
        public EfContact_MessagesDal(RealshedPackContext context) : base(context)
        {
        }
    }
}
