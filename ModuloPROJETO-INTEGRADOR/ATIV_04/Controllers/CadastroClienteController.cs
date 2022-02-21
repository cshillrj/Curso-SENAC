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
    public class CadastroClienteController : Controller
    {
        public IActionResult CadastroCliente()
        {
            return View();
        }

        [HttpPost]

        public IActionResult CadastroCliente(Cliente cadastro)
        {
            ClienteRepository cliente = new ClienteRepository();
            cliente.Insert(cadastro);
            ViewData["mensagem"] = "Cliente cadastrado com sucesso.";
            return View();
        }
        public IActionResult Lista()
        {
            ClienteRepository client = new ClienteRepository();
            List<Cliente> lista = client.Listar();
            return View(lista);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Cliente clientes)
        {
            ClienteRepository cliente = new ClienteRepository();
            Cliente client = cliente.QueryLogin(clientes);
            if(client != null)
            {
                ViewData["mensagem"] = "Cliente logado com sucesso.";
                HttpContext.Session.SetInt32("Id", client.Id);
                HttpContext.Session.SetString("Email", client.Email);
                return View();   
            }
            else
            {
                ViewData["mensagem"] = "Falha no Login.";
                return View();
            }
        }

        public IActionResult Logout(Cliente client)
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login", "CadastroCliente");
        }
    }
}