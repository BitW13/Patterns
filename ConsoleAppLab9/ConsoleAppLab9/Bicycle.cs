using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab9
{
    internal class Bicycle: Vehicle
    {
        internal Bicycle(double speed = 30,
                      double priceForKMOnePerson = 3,
                      double priceForKMOneKg = 3,
                      int maxPersons = 1,
                      double maxKg = 10) :
            base(speed, priceForKMOnePerson, priceForKMOneKg, maxPersons, maxKg)
        { }

        internal override double GetTime(double distance)
        {
            return ((double)distance) / speed;
        }
    }
}
