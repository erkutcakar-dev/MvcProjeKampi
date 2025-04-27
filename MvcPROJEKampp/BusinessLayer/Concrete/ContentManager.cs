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
    public class ContentManager : IContentService
    {
        IContentDAL _ContentDAL;

        public ContentManager(IContentDAL contentDAL)
        {
            _ContentDAL = contentDAL;
        }

        public void ContentAdd(Content content)
        {
            _ContentDAL.Insert(content);
        }

        public void ContentDelete(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList(string p)
        {
            return _ContentDAL.List(x=> x.ContentValue.Contains(p));
        }

        public List<Content> GetListByHeadingID(int id)
        {
            return _ContentDAL.List(x => x.HeadingID == id);
        }

        public List<Content> GetListByWriter(int id)
        {
           return _ContentDAL.List(x=> x.WriterID == id);
        }
    }
}
