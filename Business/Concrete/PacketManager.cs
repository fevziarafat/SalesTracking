using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PacketManager : IPacketService
    {
        private IPacketDal _packetDal;

        public PacketManager(IPacketService packetService, IPacketDal packetDal)
        {
            _packetDal = packetDal;

        }

        public List<Packet> GetAll()
        {
            return _packetDal.GetAll();
        }

        public Packet Get(int id)
        {
            return _packetDal.Get(p => p.Id == id);
        }

        public void Add(Packet packet)
        {
            _packetDal.Add(packet);
        }

        public void Update(Packet packet)
        {
            _packetDal.Update(packet);
        }

        public void Delete(Packet packet)
        {
            _packetDal.Delete(packet);
        }
    }
}
