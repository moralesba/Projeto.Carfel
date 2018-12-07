using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Projeto.Carfel.Comentarios.Interfaces;
using Projeto.Carfel.Comentarios.Models;

namespace Projeto.Carfel.Comentarios.Repositorios
{
    public class UsuarioRepositorioSerializacao : IUsuario
    {
        private List<UsuarioModel> UsuariosSalvos {get; set;} 
        public UsuarioRepositorioSerializacao()
        {
            if (File.Exists("usuarios.dat"))
            {
                UsuariosSalvos = LerArquivoSerializado();
            } else{
                UsuariosSalvos = new List<UsuarioModel>();
            }
        }        
        public UsuarioModel BuscarPorEmailESenha(string email, string senha)
        {
            throw new System.NotImplementedException();
        }

        public UsuarioModel BuscarPorId(int id)
        {
            foreach (UsuarioModel usuario in UsuariosSalvos)
            {
                if (id == usuario.ID)
                {
                    return usuario;
                }
            }
            return null;
        }

        public UsuarioModel Cadastrar(UsuarioModel usuario)
        {
            usuario.ID = UsuariosSalvos.Count + 1;
            UsuariosSalvos.Add(usuario);

            EscreverNoArquivo();
            return usuario;
        }

        private void EscreverNoArquivo()
        {
            MemoryStream memoria = new MemoryStream();
            BinaryFormatter serializadora = new BinaryFormatter();

            serializadora.Serialize(memoria, UsuariosSalvos);

            byte[] bytes = memoria.ToArray();

            File.WriteAllBytes("usuarios.dat", bytes);
        }

        public UsuarioModel Editar(UsuarioModel usuario)
        {
            throw new System.NotImplementedException();
        }
        public void Excluir(int id)
        {
            UsuarioModel usuarioBuscado = BuscarPorId(id);

            if (usuarioBuscado != null)
            {
                UsuariosSalvos.Remove(usuarioBuscado);
                EscreverNoArquivo();
            }
        }

        public List<UsuarioModel> Listar()
        {
            return UsuariosSalvos;
        }

        private List<UsuarioModel> LerArquivoSerializado()
        {
            byte[] bytesSerializados = File.ReadAllBytes("usuarios.dat");

            MemoryStream memoria = new MemoryStream(bytesSerializados);

            BinaryFormatter serializador = new BinaryFormatter();

            return (List<UsuarioModel>) serializador.Deserialize(memoria);
        }
    }
}