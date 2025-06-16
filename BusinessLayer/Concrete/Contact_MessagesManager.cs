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
    public class Contact_MessagesManager : IContact_MessagesService
    {
        private readonly IContact_MessagesDal _contact_MessagesDal;

        public Contact_MessagesManager(IContact_MessagesDal contact_MessagesDal)
        {
            _contact_MessagesDal = contact_MessagesDal;
        }

        public void TAdd(Contact_Messages entity)
        {
            _contact_MessagesDal.Add(entity);
        }

        public void TDelete(Contact_Messages entity)
        {
            _contact_MessagesDal.Delete(entity);
        }

        public Contact_Messages TGetById(int id)
        {
            return _contact_MessagesDal.GetById(id);
        }

        public List<Contact_Messages> TGetListAll()
        {
            return _contact_MessagesDal.GetAllList();
        }

        public void TUpdate(Contact_Messages entity)
        {
            _contact_MessagesDal.Update(entity);
        }
    }
}
