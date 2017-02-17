using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitFour.LojaVirtual.Dominio.Entidades
{
    class Produto
    {
        public int produtoId { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public decimal preco { get; set; }
        public string categoria { get; set; }
    }
}
