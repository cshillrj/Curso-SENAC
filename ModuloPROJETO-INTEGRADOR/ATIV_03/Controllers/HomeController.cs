using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ATIV_03.Models;

namespace ATIV_03.Controllers
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

        public IActionResult SaibaMais()
        {
            return View();
        }

        public IActionResult Cardapio()
        {
            return View();
        }

        public IActionResult RecArtigos()
        {
            return View();
        }

        public IActionResult Galeria()
        {
            return View();
        }

        public IActionResult Pedido()
        {
            return View();
        }

        public IActionResult CadastroCliente()
        {
            return View();
        }

        [HttpPost]

        public IActionResult CadastroCliente(Cadastro dados)
        {
            AgendaCadastro.Incluir(dados);
            ViewData["mensagem"] = "Usuário cadastrado com sucesso.";
            return View();

        }

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

        public IActionResult Confirmacao()
        {
            List<Cadastro> Dados = AgendaCadastro.Listar();
            return View(Dados);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
