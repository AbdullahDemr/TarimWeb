using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntitiyFramework;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void AnnouncementStatusToFalse(int id)
        {
           /* _announcementDal.AnnouncementStatusToFalse(id)*/;
            throw new NotImplementedException();
        }

        public void AnnouncementStatusToTrue(int id)
        {
            //_announcementDal.AnnouncementStatusToTrue(id);
            throw new NotImplementedException();
        }

        public void Delete(Announcement t)
        {
            _announcementDal.Delete(t);
        }

        public Announcement GetById(int id)
        {
            return _announcementDal.GetById(id);
        }

        public List<Announcement> GetAll()
        {
            return _announcementDal.GetAll();
        }

        public void Add(Announcement t)
        {
            _announcementDal.Add(t);
        }

        public void Update(Announcement t)
        {
            _announcementDal.Update(t);
        }

  
    }
}
