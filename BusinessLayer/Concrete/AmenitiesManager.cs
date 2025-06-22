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
    public class AmenitiesManager : IAmenitiesService
    {
        private readonly IAmenitiesDal _amenitiesDal;

        public AmenitiesManager(IAmenitiesDal amenitiesDal)
        {
            _amenitiesDal = amenitiesDal;
        }

        public void TAdd(Amenities entity)
        {
            _amenitiesDal.Add(entity);
        }

     
        public void TDelete(int id)
        {
            _amenitiesDal.Delete(id);
        }

        public Amenities TGetById(int id)
        {
            return _amenitiesDal.GetById(id);
        }

        public List<Amenities> TGetListAll()
        {
            return _amenitiesDal.GetAllList();
        }

        public void TUpdate(Amenities entity)
        {
            _amenitiesDal.Update(entity);
        }
    }
}
