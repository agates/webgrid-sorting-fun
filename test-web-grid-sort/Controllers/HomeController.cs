using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace testwebgridsort.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View(new List<Person>() {
                new Person() {FirstName = "Tom", LastName = "Morello", Age = 51},
                new Person() {FirstName = "John", LastName = "Mayer", Age = 38},
                new Person() {FirstName = "Jack", LastName = "White", Age = 40},
                new Person() {FirstName = "Jimmy", LastName = "Page", Age = 71},
                new Person() {FirstName = "BB", LastName = "King", Age = 89},
                new Person() {FirstName = "David", LastName = "Gilmour", Age = 69},
                new Person() {FirstName = "John", LastName = "Frusciante", Age = 45},
                new Person() {FirstName = "Stevie Ray", LastName = "Vaughan", Age = 35},
                new Person() {FirstName = "Jimi", LastName = "Hendrix", Age = 27},
                new Person() {FirstName = "Robert", LastName = "Johnson", Age = 27}
            }
            );
        }
    }
}

