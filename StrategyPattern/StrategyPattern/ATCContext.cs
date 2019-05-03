using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ATCContext
    {
        public List<string> Rates { get; set; }

        public ATCContext()
        {
            Rates = new List<string>();
        }

        public IStrategy Strategy { get; set; }
        public void Request()
        {
            Strategy.AddRate(this);
        }
    }
}
