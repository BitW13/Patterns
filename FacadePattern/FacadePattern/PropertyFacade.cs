using FacadePattern.Subsystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public static class PropertyFacade
    {
        static readonly Cottage cottage = new Cottage();
        static readonly TownHouse townHouse = new TownHouse();
        static readonly Apartment apartment = new Apartment();

        public static string CottageToString()
        {
            return cottage.ToString();
        }
        public static string TownHouseToString()
        {
            return townHouse.ToString();
        }
        public static string ApartmentToString()
        {
            return apartment.ToString();
        }
    }
}
