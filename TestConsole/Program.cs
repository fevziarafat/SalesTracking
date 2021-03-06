using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DealerManager dealerManager = new DealerManager(new EfDealerDal());
            StatusManager statusManager = new StatusManager(new EfStatusDal());
            //AddStatusAndList(statusManager);
            //AddDealer(dealerManager);
            //ListAllDealer(dealerManager);
        }

        private static void AddStatusAndList(StatusManager statusManager)
        {
            statusManager.Add(new Status
            {
                StatusName = "Aktif",
                StatusExplanation = "Aktifleştirme işlemi yapılmış"
            });
            var status = statusManager.GetAll();
            foreach (var state in status)
            {
                Console.WriteLine($"{state.Id}" + " " + $"{state.StatusName}" + " " + $"{state.StatusExplanation}");
            }
        }

        private static void ListAllDealer(DealerManager dealerManager)
        {
            var dealers = dealerManager.GetAll();
            foreach (var dealer in dealers)
            {
                Console.WriteLine($"{dealer.DealerExplanation}" + "  " + $"{dealer.DealerStatusName}");
            }
        }

        private static void AddDealer(DealerManager dealerManager)
        {
            dealerManager.Add(new Dealer
            {
                DealerExplanation = "Dealer explanation",
                DealerStatusName = "Admin",
                UserId = 1
            });
        }
    }
}
