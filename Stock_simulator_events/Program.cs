using System;

namespace Stock_simulator_events
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int value = rand.Next(1,100);

            Stock stock = new("NASDAQ OMX Group", value);
            Trader trader = new("Ivan Pupkin", 5000);
            Trader trader2 = new("Ilon Mask", 1000);

            //----testing----
            //trader.AddMoneyToAccount(1000);
            //Console.WriteLine(trader.Sum);

            stock.StockInfo();

            stock.Buy += trader.BuyCurrency;
            stock.Sell += trader.SellCurrency;
            stock.TakeMoney += trader.AddMoneyToAccount;

            //trader2 interested only to buy currency and to add money into account.
            stock.Buy += trader2.BuyCurrency;           
            stock.TakeMoney += trader2.AddMoneyToAccount;


            stock.StartStockWork(200);
            trader.TraderInfo();
            trader2.TraderInfo();
          


        }
    }
}
