using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageManager : IImageService
    {
        private readonly IImageDal _imageDal;

        public ImageManager(IImageDal ımageDal)
        {
            _imageDal = ımageDal;
        }

        public void Delete(Image t)
        {
            throw new NotImplementedException();
        }

        public Image GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Image> GetListAll()
        {
            return _imageDal.GetAll();
        }

        public void Add(Image t)
        {
            throw new NotImplementedException();
        }

        public void Update(Image t)
        {
            throw new NotImplementedException();
        }

        List<Image> IGenericService<Image>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
