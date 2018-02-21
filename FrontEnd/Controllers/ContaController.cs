using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class ContaController : Controller
    {
        public IActionResult Listar()
        {
            return View();
        }

        public ActionResult Incluir()
        {
            return View();
        }
    }
}