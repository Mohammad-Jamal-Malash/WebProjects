using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using $safeprojectname$.Models;

namespace $safeprojectname$.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BookContext context;

        public HomeController(ILogger<HomeController> logger, BookContext ctx)
        {
            _logger = logger;
            context = ctx;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var Eng = context.Generes.Where(m => m.Name == "Engineering").FirstOrDefault().Id;
            var Fantasy = context.Generes.Where(m => m.Name == "Fantasy").FirstOrDefault().Id;
            var Art = context.Generes.Where(m => m.Name == "Art").FirstOrDefault().Id;



            ViewBag.books = context.Books.ToList();
            ViewBag.Fantasy = context.Books.Where(m => m.GenreId == Fantasy).ToList();
            ViewBag.Art = context.Books.Where(m => m.GenreId == Art).ToList();
            ViewBag.Enginner = context.Books.Where(m => m.GenreId == Eng).ToList();
            return View("index");
        }


        public IActionResult Search(string searchString)
        {
            ViewBag.books = context.Books.Where(m => m.Title.StartsWith(searchString) || m.Title.EndsWith(searchString)).ToList();
            ViewBag.searchValue = searchString;
            return View("Search");
        }


        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}