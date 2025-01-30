using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day_5
{

    public class vichle : car
    {
        public string make { get; set; }
        public string model { get; set; }

        public void print()
        {
            Console.WriteLine($"This car is {make} {model} !");
        }
    }
    public class car
    {
        public int numOfDoors { get; set; }
    }




    internal class Program
    {
        static void Main(string[] args)
        {

            vichle BMW = new vichle();
            BMW.make = "BMW";
            BMW.model = "E36";
            BMW.print();




        }
    }
}
