using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// q1- Overloading -----////////////////

            Calculator room = new Calculator();
            room.Dimentions(420, 230);
            room.Dimentions(4, 2, 4);
            room.Dimentions(4.5, 2.5);
            Console.WriteLine("\r");

            //// q2- Overriding -----////////////////
            shape Shape = new shape();
            Shape.draw();

            shape cShape = new circle();
            cShape.draw();

            shape rShape = new Rectangle();
            rShape.draw();
            Console.WriteLine("\r");

            //// q3- Abstract Class -----////////////////
            Animal dog = new Dog ();
            dog.makeSound();

            Animal cat = new Cat ();
            cat.makeSound();
            cat.sleep();
            Console.WriteLine("\r");

            //// q4- Interface -----////////////////
            Iplayable guitar = new Guitar ();
            guitar.play();

            Iplayable piano = new Piano ();
            piano.play();





        }
    }


    class Calculator
    {

        //// q1- Overloading -----////////////////
        public void Dimentions(int width, int height)
        {
            Console.WriteLine($"The 1st Room Dimentions is {width}cm width & {height}cm height ! ");
        }

        public void Dimentions(int length, int width, int height)
        {
            Console.WriteLine($"The 2nd Room Area is {length * width * height }m’2 ! ");
        }

        public void Dimentions(double width, double height)
        {
            Console.WriteLine($"The 3rd Room Dimentions is {width}m width & {height}m height ! ");
        }
    }

    //// q2- Overriding -----////////////////

    class shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Draw the Shape");
        }
    }
    class circle : shape
    {
        public override void draw()
        {
            Console.WriteLine("Draw the Circle");
        }
    }
    class Rectangle : shape
    {
        public override void draw()
        {
            Console.WriteLine("Draw the Rectangle");
        }
    }


    //// q3- Abstract Class -----////////////////
    abstract class Animal
    {
        public abstract void makeSound();

        public void sleep()
        {
            Console.WriteLine("Animal is Sleeping");
        }
    }

    class Dog : Animal 
    {
        public override void makeSound()
        {
            Console.WriteLine("Dog Barks");
        }
    }

    class Cat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Cat Meows");
        }
    }


    //// q4- Interface -----////////////////
    interface Iplayable
    {
        void play();
    }

    class Guitar : Iplayable
    {
        public void play()
        {
            Console.WriteLine("Playing the guitar");
        }
    }

    class Piano : Iplayable
    {
        public void play()
        {
            Console.WriteLine("Playing the Piano");
        }
    }




}

