using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using ATIV_04.Models;

namespace ATIV_04.Controllers
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ClienteRepository cadastroCliente = new ClienteRepository();
            cadastroCliente.TestarConexao();
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }

}  
    