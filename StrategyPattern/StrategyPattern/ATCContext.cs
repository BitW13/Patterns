using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ATCContext
    {
        public List<Rate> Rates { get; set; }

        public ATCContext()
        {
            Rates = new List<Rate>();
        }

        public IStrategy Strategy { get; set; }
        public void Request(double value)
        {
            Strategy.AddRate(this, value);
        }

        public double Average()
        {
            double average = 0;
            foreach(var rate in Rates)
            {
                average += rate.Value;
            }
            return average / Rates.Count;
        }
    }
}
