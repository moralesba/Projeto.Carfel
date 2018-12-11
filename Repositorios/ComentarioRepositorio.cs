using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Projeto.Carfel.Comentarios.Models;

namespace Projeto.Carfel.Comentarios.Repositorios
{
       public class ComentarioRepositorio
    {
        public List<ComentarioModel> Comentarios;

        public ComentarioRepositorio()
        {
            if (File.Exists("comentarios.dat"))
            {
                Comentarios = LerArquivoSerializado1();
            }
            else
            {
                Comentarios = new List<ComentarioModel>();
            }
        }
        public void ReceberComentarios(ComentarioModel comentario) {  
            if (File.Exists("comentarios.dat"))
            {
                Comentarios = LerArquivoSerializado1();
            }
            else
            {
                Comentarios = new List<ComentarioModel>();
            }

            Comentarios.Add(comentario);
            Serializar(Comentarios);
        }
        public void Serializar(List<ComentarioModel> Comentarios) {
            MemoryStream memoria = new MemoryStream();
            BinaryFormatter serializadora = new BinaryFormatter();

            serializadora.Serialize(memoria, Comentarios);

            byte[] bytes = memoria.ToArray();

            File.WriteAllBytes("comentarios.dat", bytes);  
        }

        public List<ComentarioModel> LerArquivoSerializado1()
        {
            List<ComentarioModel> ComentariosDeserializados = new List<ComentarioModel>();

            byte[] bytesSerializados = File.ReadAllBytes("comentarios.dat");

            MemoryStream memoria = new MemoryStream(bytesSerializados);

            BinaryFormatter serializador = new BinaryFormatter();

            ComentariosDeserializados = (List<ComentarioModel>) serializador.Deserialize(memoria);
            return  ComentariosDeserializados;
        }
        public void Cadastro (ComentarioModel comentario) {
            ComentarioRepositorio repositorio = new ComentarioRepositorio();      
            if (File.Exists("comentarios.dat"))
            {
                Comentarios = LerArquivoSerializado2();
            }
            else
            {
                Comentarios = new List<ComentarioModel>();
            }
            Comentarios.Add(comentario);
        }

        public List<ComentarioModel> LerArquivoSerializado2()
        {
            if(!File.Exists("comentarios.dat")){
                return Comentarios;
            }
            
            byte[] bytesSerializados = File.ReadAllBytes("comentarios.dat");

            MemoryStream memoria = new MemoryStream(bytesSerializados);

            BinaryFormatter serializador = new BinaryFormatter();

            return (List<ComentarioModel>) serializador.Deserialize(memoria);
        }
    }
}
