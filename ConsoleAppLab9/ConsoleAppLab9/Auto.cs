using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab9
{
    internal class Auto : Vehicle
    {
        internal Auto(double speed = 90, 
                      double priceForKMOnePerson = 5,
                      double priceForKMOneKg = 3,
                      int maxPersons = 4,
                      double maxKg = 50) :
            base(speed, priceForKMOnePerson, priceForKMOneKg, maxPersons, maxKg)
        { }

        internal override double GetTime(double distance)
        {
            return ((double)distance) / speed;
        }
    }
}
