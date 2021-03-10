using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;

namespace Business.Concrete
{
    public class PacketManager : IPacketService
    {
        private readonly IPacketDal _packetDal;

        public PacketManager(IPacketDal packetDal)
        {
            _packetDal = packetDal;

        }

        public IDataResult<List<Packet>> GetAll()
        {
            return new SuccessDataResult<List<Packet>>(_packetDal.GetAll());
        }

        public IDataResult<Packet> Get(int id)
        {
            return new SuccessDataResult<Packet>(_packetDal.Get(p => p.Id == id));
        }
        [ValidationAspect(typeof(PacketValidator))]
        public IResult Add(Packet packet)
        {
           // ValidationTool.Validate(new PacketValidator(), packet);
            _packetDal.Add(packet);
            return new SuccessResult();
        }

        public IResult Update(Packet packet)
        {
            _packetDal.Update(packet);
            return new SuccessResult();
        }

        public IResult Delete(Packet packet)
        {
            _packetDal.Delete(packet);
            return new SuccessResult();
        }
    }
}
