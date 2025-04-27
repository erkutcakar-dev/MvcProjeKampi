using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {

        IContactDAL _ContactDAL;

        public ContactManager(IContactDAL contactsDAL)
        {
            _ContactDAL = contactsDAL;
        }

        public void ContactAdd(Contact contact)
        {
            _ContactDAL.Insert(contact);
        }

        public void ContactDelete(Contact contact)
        {
            _ContactDAL.Delete(contact);
        }

        public void ContactUpdate(Contact contact)
        {
           _ContactDAL.Update(contact);
        }

        public Contact GetByID(int id)
        {
            return _ContactDAL.Get(x => x.ContactID == id);
        }

        public List<Contact> GetList()
        {
            return _ContactDAL.List();
        }
    }
}
