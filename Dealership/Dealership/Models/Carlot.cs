using System.Collections.Generic;

namespace Dealership.Models
{
    public class CarLot
    {
        public CarLot()
        {
            Cars = new List<Car>();
        }

        public Dealer Dealer { get; set; }
        public List<Car> Cars { get; private set; }

        public static CarLot Initialize()
        {
            CarLot carLot = new CarLot()
            {
                Dealer = new Dealer()
                {
                    Name = "Code Louisville Cars"
                }
            };

            for (int carNumber = 0; carNumber < 100; carNumber++)
            {
                Car car = new Car()
                {
                    Index = carNumber,
                    Make = $"Make_{carNumber}",
                    Model = $"Model_{carNumber}",
                    Year = 2000 + carNumber
                };

                carLot.Cars.Add(car);
            }

            return carLot;
        }
    }
}