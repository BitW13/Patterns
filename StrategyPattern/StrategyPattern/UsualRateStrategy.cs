using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class UsualRateStrategy : IStrategy
    {
        public void AddRate(ATCContext context, double value)
        {
            context.Rates.Add(new Rate() { Value = value });
        }
    }
}
