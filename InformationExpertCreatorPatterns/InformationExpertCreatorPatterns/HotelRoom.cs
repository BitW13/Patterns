using System;
using System.Collections.Generic;

namespace InformationExpertCreatorPatterns
{
    public class HotelRoom
    {
        public virtual string Number { get; set; }
        public virtual Client Client { get; set; }

        public virtual int Days { get; set; }

        public virtual HotelRoomType RoomType { get; set; }

        public virtual double Price { get; set; }

        public HotelRoom()
        {
            Number = "0000";
            RoomType = HotelRoomType.Single;
            Price = 10;
        }
        public HotelRoom(string number, HotelRoomType roomType, double price)
        {
            Number = number;
            RoomType = roomType;
            Price = price;
        }
        
        public virtual string GetData()
        {
            return string.Format("HotelRoom data:\n" +
                                 "-Number: {0}\n" +
                                 "-RoomType: {1}\n" +
                                 "-Price: {2}\n", Number, RoomType, Price);
        }

        public virtual void AddClient(string firstName, string lastName, int age, int days)
        {
            if(Client == null)
            {
                Client = new Client(firstName, lastName, age);
                Days = days;
            }
            else
            {
                throw new Exception("Room is busy!");
            }
        }

        public virtual void RemoveClient()
        {
            if(Client != null)
            {
                Client = null;
            }
            else
            {
                throw new Exception("Room is not busy!");
            }
        }

        public virtual double GetPriceForLiving()
        {
            if(Client != null)
            {
                return Days * Price;
            }
            else
            {
                return 0;
            }
        }
    }
}
