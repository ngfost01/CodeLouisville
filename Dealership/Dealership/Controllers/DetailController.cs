using Dealership.Models;
using System.Web.Mvc;

namespace Dealership.Controllers
{
    public class DetailController : Controller
    {
        private CarLot _carLot;

        public DetailController()
        {
            _carLot = new CarLot()
            {
                Dealer = new Dealer()
                {
                    Name = "Code Louisville Cars"
                }
            };

            for(int carNumber = 0; carNumber < 100; carNumber++)
            {
                Car car = new Car()
                {
                    Make = $"Make_{carNumber}",
                    Model = $"Model_{carNumber}",
                    Year = 2000 + carNumber
                };

                _carLot.Cars.Add(car);
            }
        }

        // GET: Detail
        public ActionResult Index()
        {
            ViewBag.CarIndex = 0;

            return View(_carLot);
        }
    }
}