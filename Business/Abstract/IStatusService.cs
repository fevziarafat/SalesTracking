using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStatusService
    {
        List<Status> GetAll();
        Status Get(int id);
        void Add(Status status);
        void Update(Status status);
        void Delete(Status status);
    }
}
