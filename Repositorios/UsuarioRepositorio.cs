using System.Collections.Generic;
using System.IO;
using Projeto.Carfel.Comentarios.Interfaces;
using Projeto.Carfel.Comentarios.Models;

namespace Projeto.Carfel.Comentarios.Repositorios {
    public class UsuarioRepositorio : IUsuario {
        public UsuarioModel BuscarPorEmailESenha (string email, string senha) {
            List<UsuarioModel> usuariosCadastrados = CarregarDoCSV ();

            foreach (UsuarioModel usuario in usuariosCadastrados) {
                if (usuario.Email == email && usuario.Senha == senha) {
                    return usuario;
                }
            }
            return null;
        }
        public List<UsuarioModel> Listar () => CarregarDoCSV ();

        private List<UsuarioModel> CarregarDoCSV () {
            List<UsuarioModel> lsUsuarios = new List<UsuarioModel> ();

            string[] linhas = File.ReadAllLines ("usuarios.csv");

            foreach (string linha in linhas) {
                if (string.IsNullOrEmpty (linha)) {
                    continue;
                }

                string[] dadosDaLinha = linha.Split (';');

                UsuarioModel usuario = new UsuarioModel (
                    id: int.Parse (dadosDaLinha[0]),
                    nome: dadosDaLinha[1],
                    email: dadosDaLinha[2],
                    senha: dadosDaLinha[3]
                );

                lsUsuarios.Add (usuario);
            }
            return lsUsuarios;
        }
        public void Excluir (int id) {
            string[] linhas = File.ReadAllLines ("usuarios.csv");

            for (int i = 0; i < linhas.Length; i++) {
                string[] dadosDaLinha = linhas[i].Split (';');

                if (id.ToString () == dadosDaLinha[0]) {
                    linhas[i] = "";
                    break;
                }
            }
            File.WriteAllLines ("usuarios.csv", linhas);
        }

        public UsuarioModel Cadastrar (UsuarioModel usuario) {
            if (File.Exists ("usuarios.csv")) {
                usuario.ID = System.IO.File.ReadAllLines ("usuarios.csv").Length + 1;
            } else {
                usuario.ID = 1;
            }
            using (StreamWriter sw = new StreamWriter ("usuarios.csv", true)) {
                sw.WriteLine ($"{usuario.ID};{usuario.Nome};{usuario.Email};{usuario.Senha}");
            }
            return usuario;
        }

        public UsuarioModel Editar (UsuarioModel usuario) {
            string[] linhas = System.IO.File.ReadAllLines ("usuarios.csv");

            for (int i = 0; i < linhas.Length; i++) {
                if (string.IsNullOrEmpty (linhas[i])) {
                    continue;
                }

                string[] dados = linhas[i].Split (";");

                if (dados[0] == usuario.ID.ToString ()) {
                    linhas[i] = $"{usuario.ID};{usuario.Nome};{usuario.Email};{usuario.Senha}";
                    break;
                }
            }

            System.IO.File.WriteAllLines ("usuarios.csv", linhas);
            return usuario;
        }

        public UsuarioModel BuscarPorId (int id) {
            string[] linhas = System.IO.File.ReadAllLines ("usuarios.csv");

            for (int i = 0; i < linhas.Length; i++) {
                if (string.IsNullOrEmpty (linhas[i])) {
                    continue;
                }

                string[] dados = linhas[i].Split (';');

                if (dados[0] == id.ToString ()) {
                    UsuarioModel usuario = new UsuarioModel (
                        id: int.Parse (dados[0]),
                        nome: dados[1],
                        email: dados[2],
                        senha: dados[3]
                    );
                    return usuario;
                }
            }
            return null;
        }
    }
}