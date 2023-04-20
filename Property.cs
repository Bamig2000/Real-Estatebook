using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT5
{
    class Property
    {
        private string  addres, contract;
        private int floor, rooms, bathrooms;
        private double size, age, price;


      
        public Property(string addres, int floor, double age, int rooms, int bathrooms, double size, double price, string contract)
        {
            floor = Floor;
            addres = Addres;
            age = Age;
            rooms = Rooms;
            bathrooms = Bathrooms;
            size = Size;
            price = Price;
           
        }
        public string Addres
        {
            get { return addres; }
            set { addres = value; }
        }

        public int Floor
        {
            get { return floor; }
            set { floor = value; }
        }
        public double Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }
        public int Bathrooms
        {
            get { return bathrooms; }
            set { bathrooms = value; }
        }
        public double Size
        {
            get { return size; }
            set { size = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

       
        public string Contract{
            get {return contract; }
            set {contract=value; }
        }
    }
}
