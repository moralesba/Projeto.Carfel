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
            return RedirectToAction("MasterPage", "Usuario");
        }

        [HttpPost]
        public IActionResult Comentar (IFormCollection form) {
           ComentarioRepositorio comentarios = new ComentarioRepositorio();

            ViewData["Comentarios"] = comentarios.LerArquivoSerializado2();

            if (HttpContext.Session.GetString("nomeUsuario")!=null) {
                ComentarioModel comentario = new ComentarioModel();
                ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
                
                if (!string.IsNullOrEmpty(form["comentario"]) && !string.IsNullOrWhiteSpace(form["comentario"])) {
                    comentario.Texto = form["comentario"];
                }
                else {
                    TempData["AvisoComentario"] = "O comentario esta vazio";
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
                TempData["AvisoComentario"] = "";

                return Redirect("/");
            }
        }
    }
}