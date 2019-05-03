using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class PreferentialRateStrategy : IStrategy
    {
        private const double DISCOUNT = 0.25;
        public void AddRate(ATCContext context, double value)
        {
            context.Rates.Add(new Rate() { Value = value*(1- DISCOUNT) });
        }
    }
}
