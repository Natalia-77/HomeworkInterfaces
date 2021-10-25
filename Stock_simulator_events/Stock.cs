using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_simulator_events
{
    public delegate void StockDelegate(int r);

    class Stock
    {
        public event StockDelegate Buy;
        public event StockDelegate Sell;
        public event StockDelegate TakeMoney;

        public string NameCurrency { get; set; }
        public int Course { get; set; }

        public Stock(string name,int course)
        {
            NameCurrency = name;
            Course = course;
        }

        public void StartStockWork(int cur_value)
        {
            if(Course<=40)
            {
                Buy?.Invoke(cur_value);
            }
            else if (Course > 40 && Course <= 80)
            {
                Sell?.Invoke(cur_value);
            }
            else
            {
                TakeMoney?.Invoke(cur_value);
            }
        }
    }
}
