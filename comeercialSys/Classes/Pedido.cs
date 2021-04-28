using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comeercialSys.Classes
{

    public class Pedido
    {

        public int Id {get; set;}
        public DateTime Data { get; set;}

        public Cliente Cliente { get; set; }

        public Usuario Usuario { get; set; }

        public double Desconto { get; set; }

        public string situacao { get; set; }

        public List<Item> Items { get; set; }

        public Pedido()
        {
        }

        public Pedido(int id, DateTime data, Cliente cliente, Usuario usuario, double desconto, string situacao, List<Item> items)
        {
            Id = id;
            Data = data;
            Cliente = cliente;
            Usuario = usuario;
            Desconto = desconto;
            this.situacao = situacao;
            Items = items;
        }

        public Pedido(Cliente cliente, Usuario usuario, double desconto)
        {
            Cliente = cliente;
            Usuario = usuario;
            Desconto = 0.0;
        }

        //metodos - "funcionalidade"

        public void Inserir()
        {
            //conectar bd
            //inserir valores na tabela
            //atribuir id a propriedade ID
            //fecha conexão

        }

        public List<Pedido> Listar() //lista todos os produtos
        {
            List<Pedido> lista = new List<Pedido>();
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

        public double ObterValor(int id)
        {
            double valor = 0.00;
            //conectar bd
            //buscar o registros na tabela a ser calculado
            //atribuir os valor a variavel
            //fecha conexão

            return valor; 
        }

    }
}
