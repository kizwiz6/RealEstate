using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class RealEstate
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int RoomsCount { get; set; }
        public double Price { get; set; }

        public RealEstate(string city, string street, int roomsCount, double price)
        {
            City = city;
            Street = street;
            RoomsCount = roomsCount;
            Price = price;
        }
    }
}
