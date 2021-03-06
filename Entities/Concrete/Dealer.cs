using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Core.DataAccess.Entities;

namespace Entities.Concrete
{
    public class Dealer:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? DealerStatusName { get; set; }
        public string? DealerExplanation { get; set; }
    }
}
