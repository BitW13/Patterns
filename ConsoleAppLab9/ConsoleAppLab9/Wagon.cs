using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab9
{
    internal class Wagon: Vehicle
    {
        internal Wagon(double speed = 15,
                      double priceForKMOnePerson = 3,
                      double priceForKMOneKg = 3,
                      int maxPersons = 0,
                      double maxKg = 10) :
            base(speed, priceForKMOnePerson, priceForKMOneKg, maxPersons, maxKg)
        { }
        internal override double GetPriceForPersons(int numberOfPersons)
        {
            throw new Exception("Wagon is not used by transfer persons");
        }
        internal override double GetTime(double distance)
        {
            return ((double)distance) / speed;
        }
    }
}
