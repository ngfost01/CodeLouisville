using System.Web.Mvc;
using Dealership.Models;

namespace Dealership.Controllers
{
    public class ListController : Controller
    {
        private CarLot _carLot;

        public ListController()
        {
            _carLot = CarLot.Initialize();
        }

        // GET: List
        public ActionResult Index()
        {
            return View(_carLot);
        }
    }
}