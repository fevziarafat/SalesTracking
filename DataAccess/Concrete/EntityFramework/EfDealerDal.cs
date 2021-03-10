using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDealerDal : EfEntityRepositoryBase<Dealer, SalesTrackingContext>, IDealerDal
    {
        public List<DealerDetailDto> GetDealerDetails()
        {
            using (SalesTrackingContext context = new SalesTrackingContext())
            {
                var result =
                    from d in context.Dealers
                    join s in context.Users
                        on d.Id equals s.Id
                    select new DealerDetailDto
                    {
                        DealerExplanation = d.DealerExplanation,
                        DealerId = d.Id,
                        DealerStatusName = d.DealerStatusName,
                       // EMail = s.EMail,
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        //Status = s.Status,
                        UserId = s.Id
                    };
                return result.ToList();
            }
        }
    }
}
