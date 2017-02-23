using BitFour.LojaVirtual.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Web.Mvc;






namespace BitFour.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestBitFour
    {

        //operador Take é usado para selecionar os primeiros n objetos de uma coleção 
        [TestMethod]
        public void Take()
        {
            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var resultado = from num in numeros.Take(2) select num;
            int[] teste = { 5, 4 };
            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }

        //O operador Skip ignora os primeiros n objetos de uma coleção 
        [TestMethod]
        public void Skip()
        {
            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var resultado = from num in numeros.Take(5).Skip(2) select num;

            int[] teste = { 1, 3, 9 };
            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }


        [TestMethod]
        public void TestarPaginacaoFuncionando()
        {

            HtmlHelper html = null;
            

            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensPorPagina = 10,
                ItensTotal = 2
            };
          Func<int, string> paginaUrl = i => "Pagina"+i;
          //MvcHtmlString result = html.PageLinks(paginacao, paginaUrl);


   
            
         
        }

    }
}
