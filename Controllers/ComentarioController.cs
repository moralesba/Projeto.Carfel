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
        public IActionResult Cadastro(IFormCollection form) {
            int c=0;

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
                
                if (System.IO.File.Exists("comentariospaprovacao.dat")) {
                    ComentarioRepositorio comentarios = new ComentarioRepositorio();
                    List<ComentarioModel> comentarioslist = new List<ComentarioModel>();

                    comentarioslist = comentarios.LerArquivoSerializado1();

                    foreach(ComentarioModel item in comentarioslist) {
                        c++;
                    }

                    comentario.Id = c + 1;
                }

                comentarioRepositorio.CadastroPAprovacao(comentario);
                TempData["AvisoComent"] = "Comentário enviado para aprovação"; 
                return Redirect("/");
            }
            else {
                return Redirect("/");
            }
        }

        [HttpGet]
        public IActionResult Aprovacao () {
            //Se for o administrador geral que está logando, permite acessar essa tela.
            if (HttpContext.Session.GetString ("emailUsuario") == "admin@carfel.com") {

                ComentarioRepositorio comentarios = new ComentarioRepositorio();

                ViewData["ComentariosPAP"] = comentarios.LerArquivoSerializado1();

                return View ();
            }
            // Senão, redireciona para a pág index!
            return RedirectToAction ("Index", "Page");
        }

        [HttpGet]
        public IActionResult Excluir (int id) {
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();

            comentarioRepositorio.Excluir(id);

            TempData["Mensagem"] = "Comentário excluído!";

            return RedirectToAction ("Aprovacao");
        }

        [HttpGet]
        public IActionResult Aprovar (int id) {
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();

            comentarioRepositorio.Aprovar(id);

            TempData["Mensagem"] = "Comentário aprovado!";

            return RedirectToAction ("Aprovacao");
        }

        [HttpGet]
        public IActionResult Listar() {
            ComentarioRepositorio comentarios = new ComentarioRepositorio();

            ViewData["ComentariosAprovados"] = comentarios.LerArquivoSerializado2();

            return RedirectToAction ("Index", "Page");
        }
    }
}