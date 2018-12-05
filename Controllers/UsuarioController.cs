using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Projeto.Carfel.Comentarios.Interfaces;
using Projeto.Carfel.Comentarios.Models;
using Projeto.Carfel.Comentarios.Repositorios;

namespace Projeto.Carfel.Comentarios.Controllers {
    public class UsuarioController : Controller {
        public IUsuario UsuarioRepositorio { get; set; }

        public UsuarioController () {
            UsuarioRepositorio = new UsuarioRepositorio ();
        }
        [HttpGet]
        public IActionResult MasterPage (){
            return View ();
        }
        public ActionResult Cadastro () {
            return RedirectToAction("MasterPage");
        }

        [HttpPost]
        public ActionResult Cadastro (IFormCollection form) {

            UsuarioModel usuarioModel = new UsuarioModel (
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"]);

            UsuarioRepositorio.Cadastrar (usuarioModel);

            return RedirectToAction("MasterPage");
        }

        [HttpGet]
        public ActionResult Login () {
            return RedirectToAction("MasterPage");
        }
        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel (email: form["email"], senha: form["senha"]);
            UsuarioModel usuarioModel = UsuarioRepositorio.BuscarPorEmailESenha (usuario.Email, usuario.Senha);

            if (usuarioModel != null) {
                HttpContext.Session.SetString ("emailUsuario", usuarioModel.Email.ToString ());
                ViewBag.Mensagem = "Login realizado com sucesso!";
                return RedirectToAction ("MasterPage");
            } else { ViewBag.Mensagem = "Acesso negado!"; }

            TempData["UsuarioLogado"] = usuario.Nome;

            return RedirectToAction("MasterPage");
        }
        public IActionResult Listar () {
            ViewData["Usuarios"] = UsuarioRepositorio.Listar ();
            return View ();
        }

        [HttpGet]
        public IActionResult Excluir (int id) {
            UsuarioRepositorio.Excluir (id);

            TempData["Mensagem"] = "Usuário excluído";

            return RedirectToAction ("Listar");
        }
    }
}