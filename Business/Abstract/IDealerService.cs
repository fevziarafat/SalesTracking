using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IDealerService
    {
        IDataResult<List<Dealer>> GetAll();
        IDataResult<Dealer> Get(int id);
        IResult Add(Dealer dealer);
        IResult Update(Dealer dealer);
        IResult Delete(Dealer dealer);
        IDataResult<List<DealerDetailDto>> GetDealerDetails();
    }
}
