using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comeercialSys.Classes
{
    public class Item
    {
        // isto é uma propriedade
        public Produto Produto { get; set; }
        public double Quantidade { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }

        public Item()
        {
        }

        public Item(Produto produto, double quantidade, double valor, double desconto)
        {
            Produto = produto;
            Quantidade = quantidade;
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

        public List<Item> Listar() //lista todos os produtos
        {
            List<Item> lista = new List<Item>();
            //conectar bd
            //buscar registros na tabela
            //atribuir registros a lista
            //fecha conexão
            //entregar lista para quem chamou
            return lista;
        }

        public void BuscarPorProdutos(Produto produto) //lista apenas um produto
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

        public double ObterValor(Pedido pedido)
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
