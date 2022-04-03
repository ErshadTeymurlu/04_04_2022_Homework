using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_04_2022_Homework.Models.Exceptions;

namespace _04_04_2022_Homework.Models.Classes
{
    internal class Hotel
    {
        private string _name;
        private Room[] _rooms = new Room[0];
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public Hotel(string name)
        {
            Name = name;
        }
        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length + 1);
            this[_rooms.Length - 1] = room;
        }
        public void Reserve(int? roomID)
        {
            for (int i = 0; i < _rooms.Length; i++)
            {
                if (this[i].ID == roomID)
                {
                    if (this[i].IsAvailable == true)
                    {
                        this[i].IsAvailable = false;
                        Console.WriteLine($"{this[i].Name} Room has been successfully reserved!");
                        break;
                    }
                    else throw new NotAvailableException("Not available.");
                }
                else if (this[i].ID != roomID && i == _rooms.Length - 1) throw new NotFoundException("Couldn't find.");
            }
        }
        public Room this[int index]
        {
            get
            {
                return _rooms[index];
            }
            set
            {
                _rooms[index] = value;
            }
        }
    }
}
