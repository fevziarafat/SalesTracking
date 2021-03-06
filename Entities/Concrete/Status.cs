using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Entities;

namespace Entities.Concrete
{
    public class Status:IEntity
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public string? StatusExplanation { get; set; }
    }
}
