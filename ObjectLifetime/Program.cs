using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod();     // Explication of "static" using my own method.
            
            /*
            myCar.Make = "oldmobile";
            myCar.Model = "Cutlas Supreme";          // Bad way to create a object.
            myCar.Year = 1986;
            myCar.Color = "Silver";
            */

            // This is how creates a top object using the construct.
            //Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            Car myOtherCar;

            myOtherCar = myCar;     //    When I created a new object and said that they
                                    // were the same, myCar assumed myOtherCar and vice-versa.

            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make, 
                myOtherCar.Model,
                myOtherCar.Year, 
                myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            myOtherCar = null;
            myCar = null;

            Console.ReadLine();

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        /*
        public Car()
        {
            // You could load from a configuration file,
            // a database, etc.                                  // Forced Constructed.
            Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;              // This is a Construct.
            Year = year;
            Color = color;
        }
        */

        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
            //Console.WriteLine(Make); // It can't be used, cause Make parameter isn't static.
        }
    }
}
