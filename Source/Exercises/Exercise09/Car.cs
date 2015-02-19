using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise09 {
    /* make use of class from Main method like so:

        Car myCar = new Car();

        // print data about my car before setting values
        // we call the "Get..." methods here
        Console.WriteLine("Car data before setting values");
        Console.WriteLine(
            "Car data: brand is {0}, model is {1}, engine effect is {2}",
            myCar.GetBrand(), myCar.GetModelName(), myCar.GetEngineEffectInkW());
        Console.WriteLine("");

        // we now call "Set..." methods:
        myCar.SetBrand("Volvo");
        myCar.SetModelName("V40");
        myCar.SetHorsePower(145.0);

        // print data about myCar after setting values
        // we call "Get..." methods here
        Console.WriteLine("Car data after setting values");
        Console.WriteLine(
            "Car data: brand is {0}, model is {1}, engine effect is {2}",
            myCar.GetBrand(), myCar.GetModelName(), myCar.GetEngineEffectInkW());
        Console.WriteLine("");
            
        // now we create an additional Car object, but in a different way
        Car yourCar = new Car("BMW", "520i", 220.0);

        // print data about car
        // we call "Get..." methods here
        Console.WriteLine("Car data using alternative constructor");
        Console.WriteLine(
            "Car data: brand is {0}, model is {1}, engine effect is {2}",
            yourCar.GetBrand(), yourCar.GetModelName(), yourCar.GetEngineEffectInkW());
        Console.WriteLine("");
    */

    // begin copy
    class Car
    {
        private string brand;
        private string modelName;
        private double horsePower;

        // constructor creates a Car object with fields set to "empty" values
        public Car()
        {
            brand = "not set";
            modelName = "not set";
            horsePower = 0.0;
        }

        // constructor creates a Car object with fields set to what's
        // provided in parameter list
        public Car(string brand, string modelName, double horsePower)
        {
            this.brand = brand;
            this.modelName = modelName;
            this.horsePower = horsePower;
        }

        // sets value of the brand field
        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        // sets value of modelName field
        public void SetModelName(string modelName)
        {
            this.modelName = modelName;
        }

        // sets value of horsePower field
        public void SetHorsePower(double horsePower)
        {
            this.horsePower = horsePower;
        }

        // returns brand of Car
        public string GetBrand()
        {
            return brand;
        }

        // returns model name of Car
        public string GetModelName()
        {
            return modelName;
        }

        // returns horse power of Car
        public double GetHorsePower()
        {
            return horsePower;
        }

        // calculates engine effect in kilowatts (kW),
        // and returns value to caller
        public double GetEngineEffectInkW()
        {
            double effect = horsePower * 0.745699872;
            return effect;
        }
    }
    // end copy
}
