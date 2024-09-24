using Microsoft.AspNetCore.Mvc;
using MVCDependencyInjectionType.Models;
using System.Diagnostics;

namespace MVCDependencyInjectionType.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITrasient _trasient;
        private readonly IScoped _scoped;
        private readonly ISingleton _singleton;

        private readonly ITrasient _trasient2;
        private readonly IScoped _scoped2;
        private readonly ISingleton _singleton2;

        public HomeController(
            ITrasient trasient, 
            IScoped scoped, 
            ISingleton singleton,
            ITrasient trasient2,
            IScoped scoped2,
            ISingleton singleton2
            )
        {
            _trasient = trasient;
            _scoped = scoped;
            _singleton = singleton;

            _trasient2 = trasient2;
            _scoped2 = scoped2;
            _singleton2 = singleton2;
        }

        public IActionResult Index()
        {
            ViewBag.trasient = _trasient;
            ViewBag.scoped = _scoped;
            ViewBag.singleton = _singleton;

            ViewBag.trasient2 = _trasient2;
            ViewBag.scoped2 = _scoped2;
            ViewBag.singleton2 = _singleton2;


            return View();
        }

        
    }
}
