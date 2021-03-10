using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IPacketService
    {
        IDataResult<List<Packet>> GetAll();
        IDataResult<Packet> Get(int id);
        IResult Add(Packet packet);
        IResult Update(Packet packet);
        IResult Delete(Packet packet);
    }
}
