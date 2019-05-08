using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab11
{
    class Program
    {
        static void Main(string[] args)
        {
            ATCContext atc = new ATCContext();
            atc.Strategy = new UsualRateStrategy();
            atc.Request(10);
            atc.Request(5);
            atc.Strategy = new PreferentialRateStrategy();
            atc.Request(10);
            atc.Request(5);
            Console.WriteLine(atc.Average());
        }
    }
}
