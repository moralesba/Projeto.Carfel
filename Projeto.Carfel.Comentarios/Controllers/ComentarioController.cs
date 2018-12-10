using System;
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
        public IActionResult CadastroComentario() {
            return RedirectToAction("MasterPage");
        }

        [HttpPost]
        public IActionResult CadastroComentario(IFormCollection form) {

            if (HttpContext.Session.GetString("nomeUsuario")!=null) {
                ComentarioModel comentario = new ComentarioModel();
                ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
                
                if (!string.IsNullOrEmpty(form["comentario"]) && !string.IsNullOrWhiteSpace(form["comentario"])) {
                    comentario.Texto = form["comentario"];
                }
                else {
                    TempData["AvisoComent"] = "O comentário não pode está vazio!";
                    return RedirectToAction("MasterPage");
                }
                comentario.UsuarioNome =  HttpContext.Session.GetString("nomeUsuario");
                comentario.UsuarioEmail = HttpContext.Session.GetString("emailUsuario");

                comentario.DataCriacao = DateTime.Now;
                
                if (System.IO.File.Exists("Comentariospaprovacao.csv")) {
                    //Ler o arquivo e quebrar a cada *
                    
                    //-------------------------------------------------------------------------------------------------------------
                }

                comentarioRepositorio.CadastroPAprovacao(comentario);
                TempData["AvisoComent"] = "Comentário enviado para aprovação!"; 
                return RedirectToAction("MasterPage");
            }
            else {
                return RedirectToAction("MasterPage");
            }
        }

        [HttpGet]
        public IActionResult AprovacaoComentario() {
            if (HttpContext.Session.GetString("emailUsuario") == "admin@carfel.com"){
                return View();
            }
            return RedirectToAction("MasterPage");
        }
    }
}