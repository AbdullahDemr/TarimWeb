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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Delete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public Service GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> GetListAll()
        {
            return _serviceDal.GetAll();
        }

        public void add(Service t)
        {
            _serviceDal.Add(t);
        }

        public void Update(Service t)
        {
            _serviceDal.Update(t);
        }

        void IGenericService<Service>.Add(Service t)
        {
            throw new NotImplementedException();
        }

        List<Service> IGenericService<Service>.GetAll()
        {
            return _serviceDal.GetAll();  
        }

    }
}
