using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class DealerManager : IDealerService
    {
        private IDealerDal _dealerDal;

        public DealerManager(IDealerDal dealerDal)
        {
            _dealerDal = dealerDal;

        }

        public List<Dealer> GetAll()
        {
            return _dealerDal.GetAll();
        }

        public Dealer Get(int id)
        {
            return _dealerDal.Get(p => p.Id == id);
        }

        public void Add(Dealer dealer)
        {
            _dealerDal.Add(dealer);
        }

        public void Update(Dealer dealer)
        {
            _dealerDal.Update(dealer);
        }

        public void Delete(Dealer dealer)
        {
            _dealerDal.Delete(dealer);
        }
    }
}
