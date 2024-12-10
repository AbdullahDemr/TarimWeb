using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutdal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutdal = aboutDal;
        }

        public void Delete(About t)
        {
            _aboutdal.Delete(t);
        }

        public About GetById(int id)
        {
            return _aboutdal.GetById(id);   
        }

        public List<About> GetListAll()
        {
            return new List<About>();
        }

        public void Insert(About t)
        {
            _aboutdal.Insert(t);
        }

        public void Update(About t)
        {
            _aboutdal.Update(t);
        }
    }
}
