using System.Collections.Generic;
using Projeto.Carfel.Comentarios.Models;

namespace Projeto.Carfel.Comentarios.Interfaces {
    public interface IUsuario {
        UsuarioModel Cadastrar (UsuarioModel usuario);
        List<UsuarioModel> Listar ();
        void Excluir (int id);
        UsuarioModel Editar (UsuarioModel usuario);
        UsuarioModel BuscarPorEmailESenha (string email, string senha);
        UsuarioModel BuscarPorId (int id);
    }
}
