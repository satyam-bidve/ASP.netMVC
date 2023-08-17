using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.netMVC_SATYAM.Models; // need this import 

namespace ASP.netMVC_SATYAM.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            var data = GetCars();

            return View(data);
        }

        // in this method commonly we will get data from database store it in any collection class and then pass to the ActionMethod then to 
        // view as responce 
        private Cars GetCars()
        {
            return new Cars()
            {
                carID = 101,
                carName = "Supra",
                brand = "toyota"
            };
        }
    }
}