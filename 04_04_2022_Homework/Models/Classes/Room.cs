using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_04_2022_Homework.Models.Classes
{
    internal class Room
    {
        public Room(string name, double price, string personCapacity)
        {
            ID = IDPlus();
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            IsAvailable = true;
        }
        public static int IDPlus()
        {
            _id++;
            return _id;
        }
        public int ID { get; }
        private static int _id { get; set; }
        private string _name { get; set; }
        private double _price { get; set; }
        private string _personCapacity { get; set; }
        public bool IsAvailable { get; set; }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
            }
        }
        public string PersonCapacity
        {
            get { return _personCapacity; }
            set
            {
                _personCapacity = value;
            }
        }
        public string ShowInfo()
        {
            return $"----Room Information----\nName - {Name}\nPrice - {Price}\nPerson Capacity - {PersonCapacity}\nAvailable - {IsAvailable}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }

    }
}
