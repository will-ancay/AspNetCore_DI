using AspNet.Models;
using AspNetCore_DI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUsuarioRepositorio _usuarioRepo;

        public HomeController(ILogger<HomeController> logger, IUsuarioRepositorio usuarioRepo)
        {
            _logger = logger; 
            _usuarioRepo = usuarioRepo;
        }

        public IActionResult Index()
        {
            return View(_usuarioRepo.GetTodosUsuarios());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
