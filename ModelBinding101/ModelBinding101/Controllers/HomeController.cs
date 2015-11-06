using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBinding101.Models;

namespace ModelBinding101.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // RESPONSE OBJECT NO BINDING
        public ActionResult RequestForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RequestFormPost()
        {
            var p = new Person();

            p.PersonId = int.Parse(Request.Form["PersonId"]);
            p.FirstName = Request.Form["FirstName"];
            p.LastName = Request.Form["LastName"];

            return View("Result", p);
        }

        // SIMPLE BINDING
        public ActionResult SimpleBinding()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SimpleBinding(string firstName, int personId,  string lastName)
        {
            var p = new Person();
            p.PersonId = personId;
            p.FirstName = firstName;
            p.LastName = lastName;

            return View("Result", p);
        }

        // OBJECT BINDING
        public ActionResult ObjectBinding()
        {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult ObjectBinding(Person p)
        {
            return View("Result", p);
        }

        // COMPLEX CLASS BINDING
        public ActionResult BindingComplexClassTypes()
        {
            return View(new Person() {HomeAddress = new Address()});
        }

        [HttpPost]
        public ActionResult BindingComplexClassTypes(Person p)
        {
            return View("Result2", p);
        }

        // BINDING MULTIPLE OBJECTS
        public ActionResult BindingMultipleObjects()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BindingMultipleObjects(List<Address> addresses)
        {
            return View("Result3", addresses);
        }
    }
}