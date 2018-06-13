using System;

namespace CodeLouisvilleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new car
            Car myCar = new Car();
            myCar.Id = 1;
            myCar.Make = "Honda";
            myCar.Model = "CRV";
            myCar.Year = DateTime.Now;

            // Create a new super car
            Car mySportsCar = new SuperCar();
            mySportsCar.Id = 2;
            mySportsCar.Make = "Mazda";
            mySportsCar.Model = "Miata";

            //mySportsCar.HasNitrous = true;

            // Ways to acess properties on the super car
            SuperCar myActualSuperCar = (SuperCar)mySportsCar;

            myActualSuperCar.HasNitrous = true;
            myActualSuperCar.NumberFins = 7;


            // Way to set property
            ((SuperCar)mySportsCar).HasNitrous = true;
            ((SuperCar)mySportsCar).NumberFins = 7;
        }
    }
}
