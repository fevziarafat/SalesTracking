using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;

namespace Business.Concrete
{
    public class DealerManager : IDealerService
    {
        private readonly IDealerDal _dealerDal;

        public DealerManager(IDealerDal dealerDal)
        {
            _dealerDal = dealerDal;
        }

        public IDataResult<List<Dealer>> GetAll()
        {
            return new SuccessDataResult<List<Dealer>>(_dealerDal.GetAll(), Messages.DealerListed);
        }

        public IDataResult<Dealer> Get(int id)
        {
            return new SuccessDataResult<Dealer>
                (_dealerDal.Get(p => p.Id == id), Messages.DealerGeted);
        }

        [ValidationAspect(typeof(DealerValidator))]
        public IResult Add(Dealer dealer)
        {
            var result = BusinessRules.Run(CheckDealerIsExists(dealer), CheckTime(),
                CheckDealerLimit(dealer));
            if (result != null)
            {
                return result;
            }
            _dealerDal.Add(dealer);
            return new SuccessResult(Messages.DealerAdded);
        }
        public IResult Update(Dealer dealer)
        {
            _dealerDal.Update(dealer);
            return new SuccessResult(Messages.DealerUpdated);
        }
        public IResult Delete(Dealer dealer)
        {
            _dealerDal.Delete(dealer);
            return new SuccessResult(Messages.DealerDeleted);
        }

        public IDataResult<List<DealerDetailDto>> GetDealerDetails()
        {
            return new SuccessDataResult<List<DealerDetailDto>>
                (_dealerDal.GetDealerDetails(), Messages.DealerDetailsGetSuccess);
        }
        private IResult CheckDealerLimit(Dealer dealer)
        {
            var count = _dealerDal.GetAll(p => p.UserId == dealer.Id).Count;
            if (count >= 10)
            {
                return new ErrorResult(Messages.DealerLimitIsOver);
            }
            return new SuccessResult();
        }
        private static IResult CheckTime()
        {
            if (DateTime.Now.Hour == 22)
            {
                {
                    return new ErrorDataResult<List<Dealer>>(Messages.MaintenanceTime);
                }
            }
            return new SuccessResult();
        }
        private IResult CheckDealerIsExists(Dealer dealer)
        {
            var result = _dealerDal.GetAll(p => p.DealerStatusName == dealer.DealerStatusName).Any();
            if (result)
            {
                return new ErrorResult(Messages.DealerNameExists);
            }
            return new SuccessResult();
        }
    }
}
