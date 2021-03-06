﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDealerService
    {
        List<Dealer> GetAll();
        Dealer Get(int id);
        void Add(Dealer dealer);
        void Update(Dealer dealer);
        void Delete(Dealer dealer);
    }
}
