using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comeercialSys.Classes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public DateTime DataCad { get; set; }

        //metodos construtores

        public Cliente()
        {

        }
        public Cliente(int id, string nome, string cpf, string email, string telefone, string senha, DateTime dataCad)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            DataCad = dataCad;
        }

        public Cliente(string nome, string cpf, string email, string telefone, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Senha = senha;
        }

        //metodos - "funcionalidade"

        public void Inserir()
        {
            //conectar bd
            var cmd = Banco.Abrir();
            //inserir valores na tabela
            //atribuir id a propriedade ID
            //fecha conexão

        }

        public List<Cliente> Listar() //lista todos os produtos
        {
            List<Cliente> lista = new List<Cliente>();
            //conectar bd
            //buscar registros na tabela
            //atribuir registros a lista
            //fecha conexão
            //entregar lista para quem chamou
            return lista;
        }

        public void BuscarPorId(int id) //lista apenas um produto
        {
            //conectar bd
            var cmd = Banco.Abrir();
            //buscar o registros na tabela
            cmd.CommandText = "select * from clientes where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                
            }
            //atribuir os valores às prpopriedades
            //fecha conexão

        }

        public bool Alterar() //alterar produto
        {
            //conectar bd
            //buscar o registros na tabela a ser alterado
            //atribuir os valores às prpopriedades
            //registra a alteração
            //indica a alteração
            //fecha conexão

            bool alterado = false;

            return alterado;

        }
    }
}
