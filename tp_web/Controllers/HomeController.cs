﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tp_web.Models;

namespace tp_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Servicios()
        {
            
            return View();
        }

        public IActionResult Contacto()
        {
            
            return View();
        }

        

        public IActionResult Tutorial()
        {
            
            return View();
        }

        public IActionResult InicioSesion()
        {

            return View();
        }
        public IActionResult Registro()
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