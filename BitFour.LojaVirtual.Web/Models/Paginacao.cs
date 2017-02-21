using System;

namespace BitFour.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public int ItensTotal { get; set; }
        public int ItensPorPagina { get; set; }
        public int PaginaAtual { get; set; }
        public int TotalPaginas
        {

            get
            {
                //MAth.ceiling arredonda o calculo pra cima se der um numero quebrado , para dar a quantidade de paginas correto 
                return (int)Math.Ceiling((decimal)ItensTotal/ItensPorPagina);
            }
        }
    }
}