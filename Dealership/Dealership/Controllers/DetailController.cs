using Dealership.Models;
using System.Web.Mvc;

namespace Dealership.Controllers
{
    public class DetailController : Controller
    {
        private CarLot _carLot;

        public DetailController()
        {
            _carLot = CarLot.Initialize();
        }

        // GET: Detail
        public ActionResult Index(int id)
        {
            ViewBag.CarIndex = id;

            return View(_carLot);
        }

        public ActionResult Previous(int carIndex)
        {
            if (carIndex > 0)
            {
                ViewBag.CarIndex = carIndex - 1;
            }
            else
            {
                ViewBag.CarIndex = carIndex;
            }

            return View("Index", _carLot);
        }

        public ActionResult Next(int carIndex)
        {
            if (carIndex < _carLot.Cars.Count - 1)
            {
                ViewBag.CarIndex = carIndex + 1;
            }
            else
            {
                ViewBag.CarIndex = carIndex;
            }

            return View("Index", _carLot);
        }
    }
}