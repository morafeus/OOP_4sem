using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Adres
    {
        private string city;
        private string street;
        private int house;
        private int index;
        private int flat;

        public string City { get { return city; } set { city = value; } }
        public string Street { get { return street; } set { street = value; } }
        public int Index { get { return index; } set { index = value; } }
        public int House { get { return house; } set { house = value; } }
        public int Flat { get { return flat; } set { flat = value; } }

        public Adres(string city, string street, int house, int index, int flat)
        {
            City = city;
            Street = street;
            House = house;
            Index = index;
            Flat = flat;
        }
    }
}
