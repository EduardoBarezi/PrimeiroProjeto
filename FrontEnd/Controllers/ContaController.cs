using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class ContaController : Controller
    {
        public static IList<Conta> lista = new List<Conta>();

        public IActionResult Listar()
        {
            return View(lista);
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Incluir(Conta conta)
        {
            lista.Add(conta);
            return RedirectToAction("Listar");
        }
        
        public ActionResult Excluir(int id)
        {
            Conta contaRemover = lista.FirstOrDefault(x => x.Id == id);
            return View(contaRemover);
        }
    }
}