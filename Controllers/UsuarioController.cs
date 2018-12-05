using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Carfel.Comentarios.Interfaces;
using Projeto.Carfel.Comentarios.Models;

namespace Projeto.Carfel.Comentarios.Controllers {
    public class UsuarioController : Controller {
        public IUsuario UsuarioRepositorio { get; set; }

        [HttpGet]
        public ActionResult Cadastro () {
            return View ();
        }

        [HttpPost]
        public ActionResult Cadastro (IFormCollection form) {
            UsuarioModel usuarioModel = new UsuarioModel (
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"]);

            UsuarioRepositorio.Cadastrar (usuarioModel);
            ViewBag.Mensagem = "Usuário Cadastrado";
            return View ();
        }

        [HttpGet]
        public IActionResult Login () => View ();
        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel (email: form["email"], senha: form["senha"]);
            UsuarioModel usuarioModel = UsuarioRepositorio.BuscarPorEmailESenha (usuario.Email, usuario.Senha);

            if (usuarioModel != null) {
                HttpContext.Session.SetString ("idUsuario", usuarioModel.Email.ToString ());
                ViewBag.Mensagem = "Login realizado com sucesso!";
                return RedirectToAction ("Cadastrar");
            } else { ViewBag.Mensagem = "Acesso negado!"; }
            return View ();
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
    
        [HttpGet]
        public IActionResult MasterPage(){
            return View();
        }
    }
}