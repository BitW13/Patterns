using InformationExpertCreatorPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Work with GRASP";

            Hotel hotel1 = new Hotel();

            hotel1.AddHotelRoom("1", HotelRoomType.Double, 13);
            hotel1.AddHotelRoom("2", HotelRoomType.DoubleDouble, 20);
            hotel1.AddHotelRoom("3", HotelRoomType.PresidentSuite, 40);
            hotel1.AddHotelRoom("4", HotelRoomType.Single, 5);

            hotel1.Rooms[0].AddClient("Ivan", "Ivanov", 19, 2);
            hotel1.Rooms[1].AddClient("Stas", "Dubrov", 21, 3);
            hotel1.Rooms[2].AddClient("Frost", "Fire", 43, 1);
            hotel1.Rooms[3].AddClient("Greg", "Frodo", 21, 5);

            Console.WriteLine(hotel1.GetData());
            Console.WriteLine("Total clients of hotel {0}: {1}\n", hotel1.Name, hotel1.GetTotalClients());

            Console.WriteLine("Rooms of hotel {0}: \n", hotel1.Name);
            foreach(HotelRoom room in hotel1.Rooms)
            {
                Console.WriteLine("* " + room.GetData());
                Console.WriteLine("Client: {0}\n", room.Client?.GetData());
            }

            hotel1.RemoveHotelRoom(1);
            Console.WriteLine(hotel1.GetData());
        }
    }
}
