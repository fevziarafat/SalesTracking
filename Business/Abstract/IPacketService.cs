using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPacketService
    {
        List<Packet> GetAll();
        Packet Get(int id);
        void Add(Packet packet);
        void Update(Packet packet);
        void Delete(Packet packet);
    }
}
