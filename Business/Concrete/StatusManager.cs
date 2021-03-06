using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StatusManager:IStatusService
    {
        private EfStatusDal _statusDal;

        public StatusManager(EfStatusDal statusDal)
        {
            _statusDal = statusDal;
        }

        public List<Status> GetAll()
        {
            return _statusDal.GetAll();
        }

        public Status Get(int id)
        {
            return _statusDal.Get(p => p.Id == id);
        }

        public void Add(Status status)
        {
            _statusDal.Add(status);
        }

        public void Update(Status status)
        {
            _statusDal.Update(status);
        }

        public void Delete(Status status)
        {
           _statusDal.Delete(status);
        }
    }
}
