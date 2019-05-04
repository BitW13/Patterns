using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab9
{
    internal abstract class Vehicle
    {
        public double speed;
        public double priceForKMOnePerson;
        public double priceForKMOneKg;
        public int maxPersons;
        public double maxKg;

        internal Vehicle(double speed, double priceForKMOnePerson, double priceForKMOneKg, int maxPersons, double maxKg)
        {
            this.speed = speed;
            this.priceForKMOnePerson = priceForKMOnePerson;
            this.priceForKMOneKg = priceForKMOneKg;
            this.maxPersons = maxPersons;
            this.maxKg = maxKg;
        }

        internal abstract double GetTime(double distance);

        internal virtual double GetPriceForPersons(int numberOfPersons)
        {
            if (maxPersons <= numberOfPersons)
            {
                return priceForKMOnePerson * numberOfPersons;
            }
            return -1;
        }

        internal double GetPriceForCargo(double kg)
        {
            if(maxKg <= kg)
            {
                return priceForKMOneKg * kg;
            }
            return -1;
        }
    }
}
