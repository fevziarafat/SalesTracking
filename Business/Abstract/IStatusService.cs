using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStatusService
    {
        IDataResult<List<Status>> GetAll();
        IDataResult<Status> Get(int id);
        IResult Add(Status status);
        IResult Update(Status status);
        IResult Delete(Status status);
    }
}
