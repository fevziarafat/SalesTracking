using System;
using System.Text;
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
            //DealerDetailsList(dealerManager);

            byte[] numbers = { 0, 16, 104, 213 };

            Console.WriteLine(Encoding.UTF8.GetString(numbers));
            
        }

        private static void DealerDetailsList(DealerManager dealerManager)
        {
            var result = dealerManager.GetDealerDetails();
            foreach (var details in result.Data)
            {
                Console.WriteLine("First Name  :" + details.FirstName + "  "
                                  + "Last Name   :" + details.LastName + "  " +
                                  "Dealer Explanation " + details.DealerExplanation + " " +
                                  "Dealer Status Name " + details.DealerStatusName);
            }
        }

        private static void AddStatusAndList(StatusManager statusManager)
        {
            statusManager.Add(new Status
            {
                StatusName = "Aktif",
                StatusExplanation = "Aktifleştirme işlemi yapılmış"
            });
            var status = statusManager.GetAll();
            foreach (var state in status.Data)
            {
                Console.WriteLine($"{state.Id}" + " " + $"{state.StatusName}" + " " + $"{state.StatusExplanation}");
            }
        }

        private static void ListAllDealer(DealerManager dealerManager)
        {
            var dealers = dealerManager.GetAll();
            foreach (var dealer in dealers.Data)
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
