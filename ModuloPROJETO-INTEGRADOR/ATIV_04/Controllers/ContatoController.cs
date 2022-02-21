using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ATIV_04.Models;

namespace ATIV_04.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult FaleConosco()
        {
            return View();
        }

        [HttpPost]

        public IActionResult FaleConosco(Dados dados)
        {
            Agenda.Incluir(dados);
            ViewData["mensagem"] = "Agradecemos seu contato.";
            return View();
        }

        public IActionResult Feedback()
        {
            List<Dados> Dados = Agenda.Listar();
            return View(Dados);
        }

    }
}