using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.DTOs
{
    public class DealerDetailDto:IDto
    {
        public int DealerId { get; set; }
        public string? DealerStatusName { get; set; }
        public string? DealerExplanation { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public bool Status { get; set; }
    }
}
