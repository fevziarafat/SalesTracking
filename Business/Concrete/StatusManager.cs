using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StatusManager : IStatusService
    {
        private readonly IStatusDal _statusDal;

        public StatusManager(IStatusDal statusDal)
        {
            _statusDal = statusDal;
        }

        public IDataResult<List<Status>> GetAll()
        {
            var result = _statusDal.GetAll().ToList();
            return new SuccessDataResult<List<Status>>(result, "başarılı");
        }

        public IDataResult<Status> Get(int id)
        {
            return new SuccessDataResult<Status>(_statusDal.Get(p => p.Id == id));
        }
        [ValidationAspect(typeof(StatusValidator))]
        public IResult Add(Status status)
        {
            _statusDal.Add(status);
            return new SuccessResult();
        }

        public IResult Update(Status status)
        {
            _statusDal.Update(status);
            return new SuccessResult();
        }

        public IResult Delete(Status status)
        {
            _statusDal.Delete(status);
            return new SuccessResult();
        }
    }
}
