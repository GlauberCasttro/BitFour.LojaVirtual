﻿using BitFour.LojaVirtual.Dominio.Repositorio;
using BitFour.LojaVirtual.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitFour.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 3;


        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();

           

            ProdutosViewModel model = new ProdutosViewModel{

                  Produtos = _repositorio.Produtos
                .OrderBy(p => p.produtoId)
                .Skip((pagina - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina),

                Paginacao = new Paginacao{
                    PaginaAtual = pagina,
                    ItensPorPagina = ProdutosPorPagina,
                    ItensTotal =     _repositorio.Produtos.Count()

                } 
            };





            return View(model);
        }
    }
}