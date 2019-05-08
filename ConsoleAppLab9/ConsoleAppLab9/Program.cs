using System;

namespace ConsoleAppLab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("facade");
            Console.WriteLine("GetPriceForCargoAuto: " + VehicleFacade.GetPriceForCargoAuto(10));
            Console.WriteLine("GetPriceForCargoBicycle: " + VehicleFacade.GetPriceForCargoBicycle(10));
            Console.WriteLine("GetPriceForCargoWagon: "+VehicleFacade.GetPriceForCargoWagon(10));

            Console.WriteLine("GetPriceForPersonsAuto: " +VehicleFacade.GetPriceForPersonsAuto(2));
            Console.WriteLine("GetPriceForPersonsBicycle: "+VehicleFacade.GetPriceForPersonsBicycle(2));
            //Console.WriteLine("GetPriceForPersonsWagon: "+VehicleFacade.GetPriceForPersonsWagon(2));

            Console.WriteLine("GetTimeAuto: "+VehicleFacade.GetTimeAuto(10));
            Console.WriteLine("GetTimeBicycle: " + VehicleFacade.GetTimeBicycle(10));
            Console.WriteLine("GetTimeWagon: " + VehicleFacade.GetTimeWagon(10));
        }
    }
}
