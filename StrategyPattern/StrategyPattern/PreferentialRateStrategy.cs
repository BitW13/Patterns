using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class PreferentialRateStrategy : IStrategy
    {
        public void AddRate(ATCContext context)
        {
            context.Rates.Add("preferential rate");
        }
    }
}
