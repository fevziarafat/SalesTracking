using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Core.DataAccess.Entities;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IDealerDal : IEntityRepository<Dealer>
    {
        List<DealerDetailDto> GetDealerDetails();
    }
}
