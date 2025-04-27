using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageFileManager : IImageFileDAL
    {
        IImageFileDAL _ImageFileDAL;

        public ImageFileManager(IImageFileDAL ımageFileDAL)
        {
            _ImageFileDAL = ımageFileDAL;
        }

        public void Delete(ImageFile p)
        {
            throw new NotImplementedException();
        }

        public ImageFile Get(Expression<Func<ImageFile, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(ImageFile p)
        {
            throw new NotImplementedException();
        }

        public List<ImageFile> List()
        {
            return _ImageFileDAL.List();
        }

        public List<ImageFile> List(Expression<Func<ImageFile, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(ImageFile p)
        {
            throw new NotImplementedException();
        }
    }
}
