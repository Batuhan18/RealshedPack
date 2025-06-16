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
    public class SettingsManager : ISettingsService
    {
        private readonly ISettingsDal _settingsDal;
        public void TAdd(Settings entity)
        {
            _settingsDal.Add(entity);
        }

        public void TDelete(Settings entity)
        {
            _settingsDal.Delete(entity);
        }

        public Settings TGetById(int id)
        {
            return _settingsDal.GetById(id);
        }

        public List<Settings> TGetListAll()
        {
            return _settingsDal.GetAllList();
        }

        public void TUpdate(Settings entity)
        {
            _settingsDal.Update(entity);
        }
    }
}
