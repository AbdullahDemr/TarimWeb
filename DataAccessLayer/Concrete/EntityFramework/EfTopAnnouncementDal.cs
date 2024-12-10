using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfTopAnnouncementDal : GenericRepository<TopAnnouncement>, ITopAnnouncementDal
    {

        public void TopAnnouncementStatusToFalse(int id)
        {
            using var context = new AgricultureContext();
            TopAnnouncement p = context.TopAnnouncements.Find(id);
            p.Status = false;
            context.SaveChanges();
        }

        public void TopAnnouncementStatusToTrue(int id)
        {
            using var context = new AgricultureContext();
            TopAnnouncement p = context.TopAnnouncements.Find(id);
            p.Status = true;
            context.SaveChanges();
        }
    }
}
