using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntitiyFramework
{
    public class EfAnnouncementDal : GenericRepository<Announcement> , IAnnouncementDal
    {
    }
}
