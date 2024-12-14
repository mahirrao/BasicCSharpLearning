using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_Variables
{
    internal class DataTypes_Variables
    {
        /*
         * C# Datatypes
         * 1. Reference Types: class, interface, string, array, delegates
         * 2. Value Types / Built-in types: int, long, float, double, char, boolean etc.
         * 3. Pointer types: *, &
         * 4. NUllable types: That allow variables to be assigned a value or null
         */
        public static void Main(string[] args)
        {
            int age = 30;
            Console.WriteLine(age);

            long l = 1234567890123;
            float f = 0.9543f;
            double d = 1999.45621;

            char ch = 'M';
            string name = "Mayuresh";

            Boolean isTrue = false;
            //uint num = -10; // unsigned int. Only stores positive values
            //ulong ul = -45621;

            short sh = 1001;
            //ushort us = -12;

            byte b = 255;
            sbyte sb = -128; // signed byte.Stores both positive and negative values

            var something = 100; // creates a variable without defined value type
            Debug.WriteLine("something: {0}", something);
            //something = "Mayur";    // Does not allow to change the value type once created
            Debug.WriteLine("something after change: {0}", something);

            dynamic somethingNew = 1234;
            Debug.WriteLine($"somethingNew: {somethingNew}");
            somethingNew = "Ahirrao";   // Dynamic allows to change the value type
            Debug.WriteLine($"somethingNew: {somethingNew}");

            // Different ways of typing various values

            // Mentioning the number of parameters
            Debug.WriteLine("Hello {0},You are {1} years old", name, age);
            
            // Concatenating with the variables
            Debug.WriteLine("Hello " +name+ ", You are " +age+ "years old");

            // Using '$' symbol to directly add the variable in curly brackets
            Debug.WriteLine($"Hello {name}, You are {age} years old");

            Car car = new Car();

            car.accelerate();
            car.brake();

        }

    }
}
