using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_04_2022_Homework.Models.Classes;
using _04_04_2022_Homework.Models.Exceptions;

namespace _04_04_2022_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hilton = new Hotel("Hilton");
            Room rm = new Room("104", 14.5, "2");
            Room rm2 = new Room("105", 24.5, "4");
            Room rm3 = new Room("106", 34.5, "8");
            hilton.AddRoom(rm);
            hilton.AddRoom(rm2);
            hilton.AddRoom(rm3);
            Console.WriteLine(rm);
            Console.WriteLine(rm2);
            Console.WriteLine(rm3);
            Console.WriteLine();
            Console.Write("Enter ID of the room you wish to reserve: ");
            int number = Convert.ToInt32(Console.ReadLine());
            hilton.Reserve(number);
            Console.WriteLine();
            Console.WriteLine(hilton[number-1]);
            Console.ReadLine();

        }
    }
}
