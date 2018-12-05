using System;

namespace Projeto.Carfel.Comentarios.Models {

    [Serializable]
    public class UsuarioModel {
        public UsuarioModel (int iD, string nome, string email, string senha, DateTime dataNascimento) {
            this.ID = iD;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        
        public UsuarioModel(string email, string senha)
        {
            this.Email = email;
            this.Senha = senha;
        }

        public UsuarioModel(string nome, string email, string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }
        public UsuarioModel(int id, string nome, string email, string senha)
        {
            this.ID = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }
    }
}