using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab9
{
    public static class VehicleFacade
    {
        static Vehicle auto = new Auto();
        static Vehicle bicycle = new Bicycle();
        static Vehicle wagon = new Wagon();

        public static double GetPriceForPersonsAuto(int numberOfPersons)
        {
            return auto.GetPriceForPersons(numberOfPersons);
        }
        public static double GetPriceForPersonsWagon(int numberOfPersons)
        {
            return wagon.GetPriceForPersons(numberOfPersons);
        }
        public static double GetPriceForPersonsBicycle(int numberOfPersons)
        {
            return bicycle.GetPriceForPersons(numberOfPersons);
        }
        public static double GetTimeWagon(double distance)
        {
            return wagon.GetTime(distance);
        }
        public static double GetTimeAuto(double distance)
        {
            return auto.GetTime(distance);
        }
        public static double GetTimeBicycle(double distance)
        {
            return bicycle.GetTime(distance);
        }

        public static double GetPriceForCargoAuto(double kg)
        {
            return auto.GetPriceForCargo(kg);
        }
        public static double GetPriceForCargoWagon(double kg)
        {
            return wagon.GetPriceForCargo(kg);
        }
        public static double GetPriceForCargoBicycle(double kg)
        {
            return bicycle.GetPriceForCargo(kg);
        }
    }
}
