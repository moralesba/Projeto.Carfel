using System.Collections.Generic;
using System.IO;
using Projeto.Carfel.Comentarios.Models;

namespace Projeto.Carfel.Comentarios.Repositorios {
    public class UsuarioRepositorio 
    {

        public void Cadastrar(UsuarioModel usuario) {        
            StreamWriter sw = new StreamWriter("usuarios.csv", true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.Tipo}");
            sw.Close();        
        }

        public UsuarioModel Login(string Email, string Senha)
        {
            string[] lines;
            UsuarioModel usuario = new UsuarioModel();

            if (File.Exists("usuarios.csv")) {
                StreamReader sr = new StreamReader("usuarios.csv");

                while(!sr.EndOfStream) {
                    string linha = sr.ReadLine();
                    
                    if (string.IsNullOrEmpty(linha)) {
                        continue;
                    }

                    if (!string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Senha)) {

                        lines = linha.Split(";");
                    
                        if (lines[2]==Email && lines[3]==Senha) {
                            usuario.Id = int.Parse(lines[0]);
                            usuario.Nome = lines[1];
                            usuario.Email = lines[2];
                            usuario.Senha = lines[3];
                            
                            usuario.Tipo = lines[4];

                            sr.Close();
                            return usuario;
                        }
                    }

                    else {
                        break;
                    }
                }
            sr.Close();
            }
            return null;
        }
    }
}