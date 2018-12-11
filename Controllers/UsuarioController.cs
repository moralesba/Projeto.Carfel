using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Carfel.Comentarios.Models;
using Projeto.Carfel.Comentarios.Repositorios;

namespace Projeto.Carfel.Comentarios.Controllers
{
    public class UsuarioController : Controller{
        
        [HttpGet]
        public ActionResult MasterPage (){
            ComentarioRepositorio comentarios = new ComentarioRepositorio();

            ViewData["Comentarios"] = comentarios.LerArquivoSerializado2();

            return View ();
        }
        public IActionResult Cadastro () {
            return RedirectToAction("MasterPage");
        }

        [HttpPost]
        public IActionResult Cadastro(IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel();
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            
            string[] UsuariosSalvos;
            int count=0;
            string nome, email, senha;
            
            if (System.IO.File.Exists("usuarios.csv")) {
                UsuariosSalvos = System.IO.File.ReadAllLines("usuarios.csv");

                for (int i=0; i< UsuariosSalvos.Length; i++) {
                    if (!UsuariosSalvos[i].Contains("admin@carfel.com")) {
                        count++;           
                    }
                }

                if (count == UsuariosSalvos.Length) {
                    usuario.Email = "admin@carfel.com";
                    usuario.Nome = "Administrador";
                    usuario.Senha="admincarfel";
                    usuario.Tipo="admin";
                    usuario.Id =1;

                    usuarioRepositorio.Cadastrar(usuario);
                }
             }
            
            count=0;
            if (!string.IsNullOrEmpty(form["nome"])) {
                nome =form["nome"];
                if (nome.Length>=3) {
                    usuario.Nome = form["nome"];
                }
            }
            else {
                TempData["MensagemCadastro"] = "Nome obrigatório";
                return RedirectToAction("MasterPage");
            }

             if (System.IO.File.Exists("usuarios.csv")) {
                UsuariosSalvos = System.IO.File.ReadAllLines("usuarios.csv");

                
                for (int i=0; i< UsuariosSalvos.Length; i++) {
                    if (!UsuariosSalvos[i].Contains(form["email"])) {
                        count++;           
                    }
                }
                if (count == UsuariosSalvos.Length || count==0) {
                    if (!string.IsNullOrEmpty(form["email"])){
                        email = form["email"];
                        if (email.Contains("@") && email.Contains(".") && email.Length>=10) {
                            usuario.Email = form["email"];
                        }
                    } else {
                        TempData["MensagemCadastro"] = "Email inválido";
                        return RedirectToAction("MasterPage");
                    }
                } else {
                    TempData["MensagemCadastro"] = "Email ja cadastrado";
                    return RedirectToAction("MasterPage");
                }
             }
            
            if (!string.IsNullOrEmpty(form["senha"])){
                senha = form["senha"];
                if (senha.Length>=6) 
                    usuario.Senha = form["senha"];
            }
            else {
                TempData["MensagemCadastro"] = "Senha inválida (min 6 caracteres)";
                return RedirectToAction("MasterPage");
            }

            usuario.Tipo = "comum";
            
            if (System.IO.File.Exists("usuarios.csv")) {
                UsuariosSalvos = System.IO.File.ReadAllLines("usuarios.csv");

                usuario.Id = UsuariosSalvos.Length + 1;
            }

            usuarioRepositorio.Cadastrar(usuario);
            TempData["MensagemCadastro"] = "Usuário cadastrado";
            return RedirectToAction("MasterPage");
        }

        [HttpGet]
        public IActionResult Login() {
            return PartialView();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form) {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioModel usuario = usuarioRepositorio.Login(form["email"], form["senha"]);

            if  (System.IO.File.Exists("usuarios.csv")) {

                if (usuario!=null){

                    if (usuario.Email=="admin@carfel.com") {
                        HttpContext.Session.SetString("emailUsuario", usuario.Email); 
                        HttpContext.Session.SetString("nomeUsuario",usuario.Nome);

                        TempData["UsuarioLogado"] = usuario.Nome;
                        
                        return RedirectToAction("Aprovacao", "Comentario");
                    }

                    else {
                        HttpContext.Session.SetString("emailUsuario", usuario.Email);
                        HttpContext.Session.SetString("nomeUsuario",usuario.Nome);

                        TempData["UsuarioLogado"] = usuario.Nome;
                        

                        return RedirectToAction("MasterPage");
                    }
                }
            }
            TempData["MensagemLogin"]= "Usuário/senha inválido";
            return  RedirectToAction("MasterPage");
        }
        [HttpGet]
        public IActionResult Sair() {
            HttpContext.Session.Clear();  

            return Redirect("/");
        }
    }
}