using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comeercialSys.Classes
{
    public class Produto
    {

        //atributos
        //propriedades
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string CodBar { get; set; }

        public double Valor { get; set; }
        
        public double Desconto { get; set; }

        //metodos construtores

        public Produto()
        {
        }

        public Produto(string descricao, string codBar, double valor, double desconto)
        {
            Descricao = descricao;
            CodBar = codBar;
            Valor = valor;
            Desconto = desconto;
        }

        public Produto(int id, string descricao, string codBar, double valor, double desconto)
        {
            Id = id;
            Descricao = descricao;
            CodBar = codBar;
            Valor = valor;
            Desconto = desconto;
        }

        //metodos - "funcionalidade"

        public void Inserir()
        {
            //conectar bd
            //inserir valores na tabela
            //atribuir id a propriedade ID
            //fecha conexão

        }

        public List<Produto> Listar() //lista todos os produtos
        {
            List<Produto> lista = new List<Produto>();
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
            //buscar o registros na tabela
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
