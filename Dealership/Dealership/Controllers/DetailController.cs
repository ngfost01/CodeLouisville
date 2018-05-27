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
    }
}