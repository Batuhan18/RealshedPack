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
    public class PropertiesManager : IPropertiesService
    {
        private readonly IPropertiesDal _propertiesDal;

        public PropertiesManager(IPropertiesDal propertiesDal)
        {
            _propertiesDal = propertiesDal;
        }

        public void TAdd(Properties entity)
        {
            _propertiesDal.Add(entity);
        }

        public void TDelete(Properties entity)
        {
            _propertiesDal.Delete(entity);
        }

        public Properties TGetById(int id)
        {
            return _propertiesDal.GetById(id);
        }

        public List<Properties> TGetListAll()
        {
            return _propertiesDal.GetAllList();
        }

        public void TUpdate(Properties entity)
        {
            _propertiesDal.Update(entity);
        }
    }
}
