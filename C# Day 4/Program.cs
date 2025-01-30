using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day_4
{
    class Student
    {
        // Private fields (Encapsulation)
        private string name;
        private int age;
        private int studentID;

        // Auto-implemented property for Email
        public string Email { get; set; }

        // MinAge and MaxAge: Minimum and maximum age
        public const int MinAge = 18;
        public const int MaxAge = 40;

        // GetDetails to display student details
        public void GetDetails()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Student ID: {studentID}");
        }

        // Constructor to initialize the object when created
        public Student(string name, int age, int studentID)
        {
            // Using Setters to validate values
            // (this.) can be used in case of name conflict **
            Name = name;
            Age = age;
            StudentID = studentID;
        }

        // Destructor is called when the object is deleted
        ~Student()
        {
            Console.WriteLine($"The student {name} details has been deleted!");
        }

        // Getter and Setter for the Name property
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty!");
                }
            }
        }

        // Getter and Setter for the Age property
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= MinAge && value <= MaxAge)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine($"Age must be between {MinAge} and {MaxAge} years!");
                }
            }
        }

        // Getter and Setter for the StudentID property
        public int StudentID
        {
            get { return studentID; }
            set
            {
                if (value > 0)
                {
                    studentID = value;
                }
                else
                {
                    Console.WriteLine("Student ID must be positive!");
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating the first student object
            Student student1 = new Student("Ahmad", 11, 1001);
            student1.Email = "ahmad@gmail.com";
            student1.GetDetails();

            // Creating the second student object
            Student student2 = new Student("Sofyan", 24, 1002);
            student2.Email = "sofyan@gmail.com";
            student2.GetDetails();

            // Creating the third student object
            Student student3 = new Student("Rami", 23, 1003);
            student3.Email = "rami@gmail.com";
            student3.GetDetails();
        }
    }
    //////////////////////////////////////////////////////////////////////////////////////////

    /// 1-Class: A blueprint or template for creating objects that defines properties and methods.
    /// 2-Object: An instance of a class that holds data and performs actions defined by the class.
    /// 3-Class vs Object: A class is a blueprint; an object is a specific instance of that blueprint.
    /// 4-OOP Principles: 1-Encapsulation, 2-Inheritance, 3-Polymorphism, 4-Abstraction.
    /// 5-Property: A member of a class that provides controlled access to fields.
    /// 6-Field: A variable declared in a class to hold data.
    /// 7-Constructor: A special method used to initialize objects of a class.
    /// 8-Encapsulation: Hiding internal details of an object and exposing only necessary parts through controlled access.
}
