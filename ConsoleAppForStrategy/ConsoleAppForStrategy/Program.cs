using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ATCContext context = new ATCContext();
            context.Strategy = new UsualRateStrategy();
            context.Request(10);
            context.Strategy = new PreferentialRateStrategy();
            context.Request(54);

            foreach(var rate in context.Rates)
            {
                Console.WriteLine(rate.Value);
            }

            Console.WriteLine();
            Console.WriteLine("average: " + context.Average());

        }
    }
}
