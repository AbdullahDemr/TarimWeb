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
    public class TopAnnouncementManager : ITopAnnouncementService
    {
        private readonly ITopAnnouncementDal _topAnnouncementDal;

        public TopAnnouncementManager(ITopAnnouncementDal topAnnouncementDal)
        {
            _topAnnouncementDal = topAnnouncementDal;
        }
        public void TopAnnouncementStatusToFalse(int id)
        {
            _topAnnouncementDal.TopAnnouncementStatusToFalse(id);
        }

        public void TopAnnouncementStatusToTrue(int id)
        {
            _topAnnouncementDal.TopAnnouncementStatusToTrue(id);
        }

        public void Delete(TopAnnouncement t)
        {
           _topAnnouncementDal.Delete(t);
        }

        public TopAnnouncement GetById(int id)
        {
            return _topAnnouncementDal.GetById(id);
        }

        public List<TopAnnouncement> GetListAll()
        {
             return _topAnnouncementDal.GetListAll();
        }

        public void Insert(TopAnnouncement t)
        {
            _topAnnouncementDal.Insert(t);
        }

        public void Update(TopAnnouncement t)
        {
            _topAnnouncementDal.Update(t);
        }
    }
}
