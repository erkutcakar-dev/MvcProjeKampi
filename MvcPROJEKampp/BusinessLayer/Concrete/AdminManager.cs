using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {

        IAdminDAL _AdminDAL;
        public AdminManager(IAdminDAL adminDAL)
        {
            _AdminDAL = adminDAL;
        }

        public void AdminAdd(Admin admin)
        {
            _AdminDAL.Insert(admin);
        }

        public void AdminDelete(Admin admin)
        {
            _AdminDAL.Delete(admin);
        }

        public void AdminUpdate(Admin admin)
        {
            _AdminDAL.Update(admin);
        }

        public Admin GetByID(int id)
        {
            return _AdminDAL.Get(x => x.AdminID == id);
        }

        public List<Admin> GetList()
        {
            return _AdminDAL.List();
        }
    }
}
