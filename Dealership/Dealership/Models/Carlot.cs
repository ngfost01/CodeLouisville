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
    }
}