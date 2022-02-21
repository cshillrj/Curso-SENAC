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
    public class UsuarioController : Controller
    {
       public IActionResult Lista()
        {
            if(HttpContext.Session.GetInt32("Id") == null)
                return RedirectToAction("Login", "Usuario");
            UsuarioRepository ur = new UsuarioRepository();
            List<Usuario> lista = ur.Listar();
            return View(lista);
        }

        public IActionResult Excluir(int Id)
        {
            if(HttpContext.Session.GetInt32("Id") == null)
                return RedirectToAction("Login", "Usuario");
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuarioEncontrado = ur.BuscarPorId(Id);
            if(usuarioEncontrado.Id > 0)
            {
                ur.excluir(usuarioEncontrado);
            }else{
                ViewData["mensagem"] = "Usuário não encontrado.";
            }

            return RedirectToAction("Lista", "Usuario");

        }

        public IActionResult Atualizar(int Id)
        {
            if(HttpContext.Session.GetInt32("Id") == null)
                return RedirectToAction("Login", "Usuario");
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuarioEncontrado = ur.BuscarPorId(Id);

            return View(usuarioEncontrado);
        }

        [HttpPost]
        public IActionResult Atualizar(Usuario usuario)
        {
            UsuarioRepository ur = new UsuarioRepository();
            ur.atualizar(usuario);
            
            return RedirectToAction("Lista", "Usuario");
        }

        public IActionResult CadastroUsuario()
        {
            if(HttpContext.Session.GetInt32("Id") == null)
                return RedirectToAction("Login", "Usuario");
            return View();
        }

        [HttpPost]
        public IActionResult CadastroUsuario(Usuario user)
        {
            UsuarioRepository ur = new UsuarioRepository();
            ur.Insert(user);
            ViewData["mensagem"] = "Usuário cadastrado com sucesso.";
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario u)
        {
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.QueryLogin(u);
            if(usuario != null)
            {
                ViewData["mensagem"] = "Usuário logado com sucesso.";
                HttpContext.Session.SetInt32("Id", usuario.Id);
                HttpContext.Session.SetString("Nome", usuario.Nome);
                return Redirect("CadastroUsuario");   
            }
            else
            {
                ViewData["mensagem"] = "Falha no Login.";
                return View();
            }
        }

        public IActionResult Logout(Usuario u)
        {
            HttpContext.Session.Clear();

            return View("Login");
        }
    }            
}
