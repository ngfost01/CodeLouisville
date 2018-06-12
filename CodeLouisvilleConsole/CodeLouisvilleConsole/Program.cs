using System;

namespace CodeLouisvilleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Id = 1;
            myCar.Make = "Honda";
            myCar.Model = "CRV";
            myCar.Year = DateTime.Now;

            Car mySportsCar = new SuperCar();
            mySportsCar.Id = 2;
            mySportsCar.Make = "Mazda";
            mySportsCar.Model = "Miata";

            //mySportsCar.HasNitrous = true;

            SuperCar myActualSuperCar = (SuperCar)mySportsCar;

            myActualSuperCar.HasNitrous = true;
            myActualSuperCar.NumberFins = 7;


            // Way to set property
            ((SuperCar)mySportsCar).HasNitrous = true;
            ((SuperCar)mySportsCar).NumberFins = 7;
        }
    }
}
