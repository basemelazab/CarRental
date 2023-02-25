using CarRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRental.Controllers
{
    public class RentController : Controller
    {
        private CarRentalEntities1 db = new CarRentalEntities1();
        // GET: Rent
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetCar()
        {
            var car = db.CarDetails.ToList();
            return Json(car,JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Getid(int id)
        {
            var customer=(from s in db.Customers where s.CustomerId==id select s.CustomerName).ToList();
            return Json(customer, JsonRequestBehavior.AllowGet);
        }
    }
}