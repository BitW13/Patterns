using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationExpertCreatorPatterns
{
    public class Hotel
    {
        public virtual string Name { get; set; }
        public virtual List<HotelRoom> Rooms { get; set; }

        public Hotel(string name)
        {
            Name = name;
            Rooms = new List<HotelRoom>();
        }
        public Hotel()
        {
            Name = "Main Hotel";
            Rooms = new List<HotelRoom>();
        }

        public virtual string GetData()
        {
            return string.Format("Hotel data:\n" +
                                 "-Name: {0}\n" +
                                 "-Number of Rooms: {1}\n", Name, Rooms.Count);
        }

        public virtual int GetTotalClients()
        {
            int count = 0;
            foreach(HotelRoom room in Rooms)
            {
                if(room.Client != null)
                {
                    count++;
                }
            }
            return count;
        }

        public virtual void AddHotelRoom(string number, HotelRoomType roomType, double price)
        {
            if(Rooms.Find(x => x.Number == number) == null)
            {
                Rooms.Add(new HotelRoom(number, roomType, price));
            }
            else
            {
                throw new Exception("The room exist!");
            }
        }
        public virtual void RemoveHotelRoom(int index)
        {
            if(Rooms.Count > index)
            {
                Rooms.RemoveAt(index);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public virtual double GetTotalPrice()
        {
            double sum = 0;
            foreach(HotelRoom room in Rooms)
            {
                sum += room.GetPriceForLiving();
            }

            return sum;
        }
    }
}
