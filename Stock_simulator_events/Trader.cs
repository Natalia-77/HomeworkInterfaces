using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_simulator_events
{

    class Trader
    {
        public string Name { get; set; }
        public int Sum { get; set; }

        public Trader(string name, int sum)
        {
            Name = name;
            Sum = sum;
        }
        
        public void AddMoneyToAccount(int value)
        {
            Sum += value;
        }

        public void BuyCurrency(int sum_buy)
        {
            if (Sum >= sum_buy)
            {
                Sum -= sum_buy;
            }
            else
            {
                Sum = sum_buy;
            }
        }

        public void SellCurrency(int sum_sell)
        {
            Sum += sum_sell;

        }

        public void TraderInfo()
        {
            Console.WriteLine($"Trader {Name} has {Sum} money");
        }

       
    }


}
