using System.Web.Mvc;
using HarborFirstDeux.Models;
using HarborFirstDeux.Persistence;

namespace HarborFirstDeux.Controllers
{
    public class HomeController : Controller
    {
        private readonly HfdContext _context = new HfdContext();

        public ActionResult Index()
        {
            return View(_context.Users);
        }

        public ActionResult Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}