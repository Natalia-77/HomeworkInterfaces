using System;

namespace Stock_simulator_events
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock("Forex", 50);
            Trader trader = new Trader("Ivan Pupkin", 5000);

            //----testing----
            //trader.AddMoneyToAccount(1000);
            //Console.WriteLine(trader.Sum);

            stock.Buy += trader.BuyCurrency;
            stock.Sell += trader.SellCurrency;
            stock.StartStockWork(100);
            Console.WriteLine(trader.Sum);


        }
    }
}
