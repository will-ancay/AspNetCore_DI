using AspNetCore_DI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_DI.Controller
{
    public class HomeController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepo;
        public HomeController(IUsuarioRepositorio usuarioRepo)
        {
            _usuarioRepo = usuarioRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            _usuarioRepo.GetTodosUsuarios();
            return null;
        }
    }
}
