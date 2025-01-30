using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // q1

            Console.WriteLine("name");
            string inputName = Console.ReadLine();

            Console.WriteLine("full name" + " " + inputName);


            //q2

            double x = 3.14159;
           // double x = 3.14159;
            Console.WriteLine(x);

            string name1 = "sofyan";
            Console.WriteLine(name1);

            char charecter1 = 's';
            Console.WriteLine(charecter1);

            bool isActive = true;
            Console.WriteLine(isActive);

            int age = 30;
            Console.WriteLine(age);

            const int z = 2025;
            Console.WriteLine(z);


            //q3

            string[] car = { "Toyota", "Honda", "BMW", "Mercedes" };
            for (int i = 0; i < car.Length; i++)
            {
                Console.WriteLine(car[i]);
            }


            //q4

            Console.WriteLine("firstname: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("lastname: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("year of birth: ");
            string yearOfBirth = Console.ReadLine();

            Console.WriteLine(firstName + " " + lastName + " " + yearOfBirth);


            //q5


            int[] array = new int[10];

            Console.WriteLine("Enter 10 numbers:");

            Console.Write("Enter number : ");
            for (int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("\nThe numbers is :");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i] + " ");
            }


        }

    }
}
