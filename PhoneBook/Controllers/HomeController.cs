using Microsoft.AspNet.Identity.Owin;
using PhoneBook.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneBook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult EmployeeCard(string id)
        {
            var db = new PhoneBookContext();
            ViewBag.Employee = db.Employees
                .Where(x => x.Id == id)
                .FirstOrDefault();

            return View();
        }
    }
}