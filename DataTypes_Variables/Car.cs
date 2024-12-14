using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_Variables
{
    public class Car
    {
        string colour;
        string brand;

        public void accelerate()
        {
            Console.WriteLine("Car is accelerating");
        }

        public void brake()
        {
            Console.WriteLine("Car is slowing down");
        }
    }
}
