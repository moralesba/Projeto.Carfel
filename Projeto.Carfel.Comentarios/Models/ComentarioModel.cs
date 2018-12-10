using System;

namespace Projeto.Carfel.Comentarios.Models
{
    public class ComentarioModel
    {
        public string UsuarioNome { get; set; }
        public string UsuarioEmail {get;set;}
        public int Id { get; set; }
        public string Texto { get; set; }
        public bool Aprovado { get; set; }        
        public  DateTime DataCriacao { get; set; }
    }
}