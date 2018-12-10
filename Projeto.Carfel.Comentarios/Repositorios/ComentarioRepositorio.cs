using System.IO;
using Projeto.Carfel.Comentarios.Models;

namespace Projeto.Carfel.Comentarios.Repositorios
{
        public class ComentarioRepositorio
    {
        public void Cadastrar(ComentarioModel comentario) {
            StreamWriter sw = new StreamWriter("comentarios.csv", true);
            sw.WriteLine($"{comentario.Id};{comentario.UsuarioNome};{comentario.UsuarioEmail};{comentario.Texto};{comentario.DataCriacao};{comentario.Aprovado}");
            sw.Close(); 
        }
        public void CadastroPAprovacao (ComentarioModel comentario) {
            StreamWriter sw = new StreamWriter("comentariospaprovacao.csv", true);
            sw.WriteLine($"{comentario.Id};{comentario.UsuarioNome};{comentario.UsuarioEmail};{comentario.Texto};{comentario.DataCriacao};{comentario.Aprovado};*");
            sw.Close(); 
        }
    }
}
