using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Projeto.Carfel.Comentarios.Models;

namespace Projeto.Carfel.Comentarios.Repositorios
{
       public class ComentarioRepositorio
    {
        public List<ComentarioModel> ComentariosPAP {get;set;}
        public List<ComentarioModel> ComentariosAprovados{get;set;}

        public void CadastroPAprovacao(ComentarioModel comentario) {  
            ComentarioRepositorio repositorio = new ComentarioRepositorio();      
            if (File.Exists("comentariospaprovacao.dat"))
            {
                ComentariosPAP = LerArquivoSerializado1();
            }
            else
            {
                ComentariosPAP = new List<ComentarioModel>();
            }

            ComentariosPAP.Add(comentario);
            repositorio.Serializar(ComentariosPAP);
        }
        public void Serializar(List<ComentarioModel> ComentariosPAP) {
            MemoryStream memoria = new MemoryStream();
            BinaryFormatter serializadora = new BinaryFormatter();

            serializadora.Serialize(memoria, ComentariosPAP);

            byte[] bytes = memoria.ToArray();

            File.WriteAllBytes("comentariospaprovacao.dat", bytes);  
        }

        public List<ComentarioModel> LerArquivoSerializado1()
        {
            List<ComentarioModel> ComentariosDeserializados = new List<ComentarioModel>();

            byte[] bytesSerializados = File.ReadAllBytes("comentariospaprovacao.dat");

            MemoryStream memoria = new MemoryStream(bytesSerializados);

            BinaryFormatter serializador = new BinaryFormatter();

            ComentariosDeserializados = (List<ComentarioModel>) serializador.Deserialize(memoria);
            return  ComentariosDeserializados;
        }
        public void Cadastro (ComentarioModel comentario) {
            ComentarioRepositorio repositorio = new ComentarioRepositorio();      
            if (File.Exists("comentariosaprovados.dat"))
            {
                //Ler o arquivo
                ComentariosAprovados = LerArquivoSerializado2();
            }
            else
            {
                ComentariosAprovados = new List<ComentarioModel>();
            }

            ComentariosAprovados.Add(comentario);
            repositorio.SerializarAprovados(ComentariosAprovados);
        }

        public void SerializarAprovados(List<ComentarioModel> ComentariosAprovados) {
            MemoryStream memoria = new MemoryStream();
            BinaryFormatter serializadora = new BinaryFormatter();

            serializadora.Serialize(memoria, ComentariosAprovados);

            byte[] bytes = memoria.ToArray();

            File.WriteAllBytes("comentariosaprovados.dat", bytes);  
        }

        public List<ComentarioModel> LerArquivoSerializado2()
        {
            byte[] bytesSerializados = File.ReadAllBytes("comentariosaprovados.dat");

            MemoryStream memoria = new MemoryStream(bytesSerializados);

            BinaryFormatter serializador = new BinaryFormatter();

            return (List<ComentarioModel>) serializador.Deserialize(memoria);
        }

        public void Aprovar(int id) {
            ComentarioRepositorio comentarios = new ComentarioRepositorio();
            List<ComentarioModel> comentarioslist = new List<ComentarioModel>();
            List<ComentarioModel> comentariosaprovados = new List<ComentarioModel>();

            comentarioslist = comentarios.LerArquivoSerializado1();

            foreach (ComentarioModel item in comentarioslist) {
                if (item.Id == id) {
                    item.Aprovado=true;
                    comentariosaprovados.Add(item);
                    comentarios.Excluir(id);
                    break;
                }
            }
            comentarios.SerializarAprovados(comentariosaprovados);
        }

        public void Excluir(int id) {
            ComentarioRepositorio comentarios = new ComentarioRepositorio();
            List<ComentarioModel> comentarioslist = new List<ComentarioModel>();

            comentarioslist = comentarios.LerArquivoSerializado1();

            foreach (ComentarioModel item in comentarioslist) {
                if (item.Id == id) {
                    comentarioslist.Remove(item);
                    break;
                }
            }
            comentarios.Serializar(comentarioslist);
        }
        
    }
}
