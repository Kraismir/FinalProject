using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCarStore.Models;

namespace MvcCarStore.Controllers
{
    public class HomeController : Controller
    {
        CarStoreEntities storeDB = new CarStoreEntities();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var cars = GetТopSellingCars(5);

            return View(cars);
        }
        private List<Car> GetТopSellingCars(int count)
        {
            return storeDB.Cars
                .OrderByDescending(c => c.OrderDetails.Count())
                .Take(count)
                .ToList();
        }

    }
}
