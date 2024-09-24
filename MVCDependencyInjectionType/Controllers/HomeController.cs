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

        public HomeController(ITrasient trasient, IScoped scoped, ISingleton singleton)
        {
            _trasient = trasient;
            _scoped = scoped;
            _singleton = singleton;
        }

        public IActionResult Index()
        {
            ViewBag.trasient = _trasient;
            ViewBag.scoped = _scoped;
            ViewBag.singleton = _singleton;


            return View();
        }

        
    }
}
