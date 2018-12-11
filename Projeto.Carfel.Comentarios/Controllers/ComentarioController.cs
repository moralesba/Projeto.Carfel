using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Carfel.Comentarios.Models;
using Projeto.Carfel.Comentarios.Repositorios;

namespace Projeto.Carfel.Comentarios.Controllers
{
        public class ComentarioController : Controller {

        [HttpGet]
        public ActionResult MasterPage (){
            return View ();
        }
        public IActionResult Cadastro() {
            return RedirectToAction("MasterPage");
        }

        [HttpPost]
        public IActionResult Comentar (IFormCollection form) {

            if (HttpContext.Session.GetString("nomeUsuario")!=null) {
                ComentarioModel comentario = new ComentarioModel();
                ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
                
                if (!string.IsNullOrEmpty(form["comentario"]) && !string.IsNullOrWhiteSpace(form["comentario"])) {
                    comentario.Texto = form["comentario"];
                }
                else {
                    TempData["AvisoComent"] = "O comentario esta vazio";
                    return Redirect("/");
                }
                comentario.UsuarioNome =  HttpContext.Session.GetString("nomeUsuario");
                comentario.UsuarioEmail = HttpContext.Session.GetString("emailUsuario");
                comentario.DataCriacao = DateTime.Now;

                comentarioRepositorio.ReceberComentarios(comentario);
                TempData["AvisoComent"] = "Comentario enviado"; 
                return Redirect("/");
            }
            else {
                return Redirect("/");
            }
        }

        [HttpGet]
        public IActionResult Listar() {
            ComentarioRepositorio comentarios = new ComentarioRepositorio();

            ViewData["Comentarios"] = comentarios.LerArquivoSerializado2();

            return Redirect ("/");
        }
    }
}