﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcCoreAspNet.Models;

namespace MvcCoreAspNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var filme = new Filme
            {
                Titulo = "oi",
                DataLancamento = DateTime.Now,
                Genero =  null,
                Avaliacao = 10,
                Valor = 20000
            };

            return RedirectToAction("Privacy", filme);
            //return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy(Filme filme)
        {
            if (ModelState.IsValid)
            {

            }

            foreach(var error in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
