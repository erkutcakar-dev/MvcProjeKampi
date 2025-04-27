using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterLoginManager : IWriterLoginService
    {
        IWriterDAL _WriterDal;

        public WriterLoginManager(IWriterDAL writerDal)
        {
            _WriterDal = writerDal;
        }

        public Writer GetWriter(string username, string password)
        {

            return _WriterDal.Get(x => x.WriterMail == username && x.WriterPassword == password);
        }
    }
}
