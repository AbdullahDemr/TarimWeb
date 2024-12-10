using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITopAnnouncementService : IGenericService<TopAnnouncement>
    {

        void TopAnnouncementStatusToTrue(int id);
        void TopAnnouncementStatusToFalse(int id);
    }
}
