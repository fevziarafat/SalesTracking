using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Core.DataAccess.Entities;

namespace Entities.Concrete
{
    public class Packet : IEntity
    {
        public int Id { get; set; }
        public string PacketName { get; set; }
        public string? PacketExplanation { get; set; }
    }
}
