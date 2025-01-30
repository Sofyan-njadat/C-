using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            ////////// q1
            ///

            Console.WriteLine("Convert double to int , Enter The Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            int num2 = (int)num1;

            Console.WriteLine($"The Doublel Number is : {num1}");
            Console.WriteLine($"The Converted Number is : {num2}");



            ////////q2
            ///

            Console.WriteLine("Convert Number to String , Enter the Number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            string num4 = Convert.ToString(num3);

            Console.WriteLine($"Your Number is: {num4}");


            ////////q3
            ///

            string content1 = "C# is Fun! ";

            string upperCase = content1.ToUpper();
            string lowerCase = content1.ToLower();

            Console.WriteLine(upperCase);
            Console.WriteLine(lowerCase);



            ////////q4
            ///

            Console.Write("Enter your first name: ");
            string fName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lName = Console.ReadLine();

            string fullName = fName + " " + lName;
            int chaLength = fullName.Length;


            Console.WriteLine(fullName);
            Console.WriteLine(chaLength);


            ////////q5
            ///

            Console.WriteLine("The Smaller Number , Enter 1st Number :");
            int numX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number :");
            int numY = Convert.ToInt32(Console.ReadLine());

            int smallerNum = (numX < numY) ? numX : numY;
            Console.WriteLine($"The Smaller Number is : {smallerNum} ");


            ////////q6
            ///

            Console.WriteLine("Enter The Kilometer :");
            int kilo = Convert.ToInt32(Console.ReadLine());

            double mile = kilo * 0.627;

            Console.WriteLine($"{mile} mph");


            ////////q7
            ///

            Console.WriteLine("Enter the Hours : ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Minutes : ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int totalMinutes = ((hours * 60) + minutes);
            Console.WriteLine($"The total is :{totalMinutes}");


            ////////q8
            ///

            Console.WriteLine("Enter the total Minutes : ");
            int totalMinutes01 = Convert.ToInt32(Console.ReadLine());

            int hoursX = totalMinutes01 / 60;
            int minutesX = totalMinutes01 % 60;

            Console.WriteLine($"{hoursX}H , {minutesX}M");


            ////////q9-A
            ///

            Console.WriteLine("Greater & Smaller , Enter The 1st Number :");
            int num5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The 2nd Number :");
            int num6 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num5 == num6 ? "Equal" : num5 > num6 ? "Greater" : "Smaller");


            ////////q9-B!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            ///

            Console.Write("Sum of digits , Enter a number: ");
            int num7 = (Convert.ToInt32(Console.ReadLine()));

            int sum = 0;

            for (; num7 > 0; num7 /= 10) // حلقة for مبسطة بدون شرط معقد
            {
                sum += num7 % 10; // إضافة الرقم الأخير إلى المجموع
            }

            Console.WriteLine($"Sum of digits: {sum}");


            ////////q10 !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            ///

            Console.Write("Reversed Number , Enter a number: ");
            int num8 = Convert.ToInt32(Console.ReadLine());
            int reversed = 0; // لتخزين الرقم المعكوس

            // حلقة لعكس الرقم
            while (num8 != 0)
            {
                int lastDigit = num8 % 10;        // الحصول على آخر رقم
                reversed = (reversed * 10) + lastDigit; // بناء الرقم العكسي
                num8 /= 10;                      // إزالة الرقم الأخير
            }

            Console.WriteLine($"Reversed Number: {reversed}");


            ////////q11
            ///

            Console.WriteLine("Check Divisibility , Enter the 1st number : ");
            int num9 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Check Divisibility , Enter the 2nd number : ");
            int num10 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num9 != 0 && num9 % num10 == 0 ? "Divisible" : "Not Divisible");


            ////////q12
            ///

            Console.WriteLine("Middle Value , Enter the 1st number :");
            int mun11 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Middle Value , Enter the 2nd number :");
            int mun12 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Middle Value , Enter the 3rd number :");
            int mun13 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The middle value is: {((mun11 > mun12 && mun11 < mun13) || (mun11 < mun12 && mun11 > mun13) ? mun11 : (mun12 > mun11 && mun12 < mun13) || (mun12 < mun11 && mun12 > mun13) ? mun12 : mun13)}");

        }

    }
}
