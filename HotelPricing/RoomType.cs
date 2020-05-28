using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPricing
{
    class RoomType
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public decimal RoomPrice { get; set; }
        public decimal AllInclusivePrice { get; set; }

        public string Text { get { return ToString(); } } 

        public RoomType(int id, string name, decimal roomPrice, decimal allInclusivePrice)
        {
            Id = id;
            Name = name;
            RoomPrice = roomPrice;
            AllInclusivePrice = allInclusivePrice;
        }

        public override string ToString()
        {
            return $"{Name} {RoomPrice} руб. в день" ; 
        }
    }
}
