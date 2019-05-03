using AdapterPattern;
using FacadePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForAdaptedAndFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter pattern");

            ITarget adapter = new GasBalloonObjAdapter();
            Console.WriteLine(adapter.GetData());
            adapter.ModifMass(10);
            Console.WriteLine(adapter.CalculateDp(1,12));

            Console.WriteLine();

            Console.WriteLine("Facade pattern");
            Console.WriteLine(PropertyFacade.ApartmentToString());
            Console.WriteLine(PropertyFacade.CottageToString());
            Console.WriteLine(PropertyFacade.TownHouseToString());
        }
    }
}
