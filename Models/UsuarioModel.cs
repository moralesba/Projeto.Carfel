using System;

namespace Projeto.Carfel.Comentarios.Models {
     [Serializable()]
    public class UsuarioModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Id { get; set; }
        public string Tipo { get; set; }

    }
}