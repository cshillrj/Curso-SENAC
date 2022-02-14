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
using ATIV_02.Models;

namespace ATIV_02.Controllers
{
    public class PacotesTuristicosController : Controller
    {
        public IActionResult Lista()
        {
            if(HttpContext.Session.GetInt32("Id") == null)
                return RedirectToAction("Login", "Usuario");
            PacotesRepository pacotes = new PacotesRepository();
            List<PacotesTuristicos> lista = pacotes.Listar();
            return View(lista);
        }

        public IActionResult Excluir(int Id)
        {
            if(HttpContext.Session.GetInt32("Id") == null)
                return RedirectToAction("Login", "Usuario");
            PacotesRepository pacote = new PacotesRepository();
            PacotesTuristicos pacoteEncontrado = pacote.BuscarPorId(Id);
            if(pacoteEncontrado.Id > 0)
            {
                pacote.Excluir(pacoteEncontrado);
            }else{
                ViewData["mensagem"] = "Pacote Turístico não encontrado.";
            }

            return RedirectToAction("Lista", "PacotesTuristicos");

        }

        public IActionResult Atualizar(int Id)
        {
            if(HttpContext.Session.GetInt32("Id") == null)
                return RedirectToAction("Login", "Usuario");
            PacotesRepository pacote = new PacotesRepository();
            PacotesTuristicos pacoteEncontrado = pacote.BuscarPorId(Id);

            return View(pacoteEncontrado);
        }

        [HttpPost]
        public IActionResult Atualizar(PacotesTuristicos pacotes)
        {
            PacotesRepository pacote = new PacotesRepository();
            pacote.Atualizar(pacotes);
            
            return RedirectToAction("Lista", "PacotesTuristicos");
        }

        public IActionResult CadastroPacotes()
        {
            if(HttpContext.Session.GetInt32("Id") == null)
                return RedirectToAction("Login", "Usuario");
            return View();
        }

        [HttpPost]
        public IActionResult CadastroPacotes(PacotesTuristicos pacotes)
        {
            PacotesRepository pacote = new PacotesRepository();
            pacote.Inserir(pacotes);
            ViewData["mensagem"] = "Pacote Turístico cadastrado com sucesso.";
            return View();
        }
        
    }
}