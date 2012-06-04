using System.Web.Mvc;
using HarborFirstDeux.Models;
using HarborFirstDeux.Persistence;
using System.Web.Configuration;

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

        public ActionResult Config()
        {
            var webConfigPath = WebConfigurationManager.OpenWebConfiguration("~").FilePath;
            return Content(System.IO.File.ReadAllText(webConfigPath), "text/plain");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}