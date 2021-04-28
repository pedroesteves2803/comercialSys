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
    }
}
