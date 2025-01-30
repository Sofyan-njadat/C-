using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day_3
{
    public class Room
    {
        public int roomNumber;
        public string roomType;
        public double Price;
        public bool IsBooked;
        public const string HotelName = "Grand Stay Hotel";
    }
    internal class Program
    {
        ////////q1
        public static void checkNumbers(int num1)
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine($"The number {num1} is EVEN");
            }
            else
            {
                Console.WriteLine($"The number {num1} is ODD");
            }
        }


        ///////q2

        public static int findSmallest(int a, int b, int c, int d, int e)
        {
            int[] numbers = { a, b, c, d, e };
            Array.Sort(numbers);
            return numbers[1];
        }


        ///////q3

        public static int factorialNum(int num2)
        {
            int factorial = 1;

            for (int i = 1; i <= num2; i++)
            {
                factorial *= i;
            }

            return factorial;
        }


        ///////q4

        public static bool IsPrime(int num3)
        {
            if (num3 < 2) return false;

            for (int i = 2; i < num3; i++)
            {
                if (num3 % i == 0) return false;
            }

            return true;
        }


        ///////q5

        public static int FindLargest(int[] arr)
        {
            int largest = arr[0];

            foreach (int num4 in arr)
            {
                if (num4 > largest)
                {
                    largest = num4;
                }
            }

            return largest;
        }


        ///////q6

        public static void PrintPattern(int n)
        {
            int currentNumber = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                }
                Console.WriteLine();
            }
        }













        ////////////////////////////////////    Main    /////////////////////////////////////////////////////////////
        ///
        public static void Main(string[] args)
        {
            //q1

            Console.WriteLine("Check EVEN / ODD , Enter the Number :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            checkNumbers(num1);

            Console.WriteLine("\n");




            //q2

            Console.WriteLine("Find the 2nd Smaller , Enter 5 numbers:");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int secondSmallest = findSmallest(a, b, c, d, e);
            Console.WriteLine($"The 2nd smallest number is: {secondSmallest}");

            Console.WriteLine("\n");



            //q3

            Console.Write("Calculate the factorial , Enter the number : ");

            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = factorialNum(num2);

            Console.WriteLine($"The factorial of Number {num2} is: {result}");

            Console.WriteLine("\n");



            //q4

            Console.Write("Primee Number , Enter the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the last number: ");
            int last = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Prime numbers between {first} and {last} :");

            for (int num3 = first; num3 <= last; num3++)
            {
                if (IsPrime(num3))
                {
                    Console.Write(num3 + " ");
                }
            }

            Console.WriteLine("\n");



            //q5


            int[] numbers = { 3, 1, 4, 1, 5, 9 };

            int largestNumber = FindLargest(numbers);

            Console.WriteLine($"The largest number in the array is: {largestNumber}");

            Console.WriteLine("\n");



            //q6

            Console.Write("Print Pattern , Enter the value of n : ");
            int n = Convert.ToInt32(Console.ReadLine());

            PrintPattern(n);

            Console.WriteLine("\n");



            //q7

            Room room = new Room();

            Console.WriteLine("Please Enter room number :");
            int numberOfRoom = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter room Type : Single, Double, Suite");
            string typeOfRoom = Console.ReadLine();
            Console.WriteLine("Please Enter room Price :");
            double PriceOfRoom = Convert.ToDouble(Console.ReadLine());


            room.roomNumber = numberOfRoom;
            room.Price = PriceOfRoom;
            room.roomType = typeOfRoom; ;








        }
    }
}
