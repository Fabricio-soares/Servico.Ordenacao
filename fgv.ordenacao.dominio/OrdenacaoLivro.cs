using fgv.ordenacao.dominio.Entidades;
using fgv.ordenacao.dominio.Interface;
using fgv.ordenacao.dominio.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static fgv.ordenacao.dominio.Util.ParametroOrdenacao;

namespace fgv.ordenacao.dominio
{
    public class OrdenacaoLivro : IOrdenacaoLivro
    {

        public async Task<List<Livro>> OrdenarLivroAsync(ParametrosOrdenacao parametrosOrdenacao, MetodoOrdenacao metodoOrdenacao, List<Livro> livros)
        {
                if (livros == null)
                    throw new OrdenacaoException($"Não é possivel realizar uma ordenação");

                if (livros.Count == 0)
                    return livros;

                switch (parametrosOrdenacao)
                {
                    case ParametrosOrdenacao.Autor:
                        livros = await OrdenarPorAutor(livros, metodoOrdenacao);
                        break;
                    case ParametrosOrdenacao.Titulo:
                        livros = await OrdenarPorTitulo(livros, metodoOrdenacao);
                        break;
                    case ParametrosOrdenacao.Edicao:
                        livros = await OrdenarPorEdisao(livros, metodoOrdenacao);
                        break;
                    case ParametrosOrdenacao.AutorTitulo:
                        livros = await OrdenarPorAutorTitulo(livros, metodoOrdenacao);
                        break;
                    case ParametrosOrdenacao.EdicaoAutorTitulo:
                        livros = await OrdenarPorEdicaoAutorTitulo(livros, metodoOrdenacao);
                        break;
                    default:
                        break;
                }

            return livros;
        }

        private async Task<List<Livro>> OrdenarPorEdicaoAutorTitulo(List<Livro> livros, MetodoOrdenacao metodoOrdenacao)
        {
            switch (metodoOrdenacao)
            {
                case MetodoOrdenacao.AscendenteDescendente:
                    livros = livros.OrderBy(e => e.Edicao).ThenBy(a => a.Autor).ThenByDescending(t => t.Titulo).ToList();
                    break;
                case MetodoOrdenacao.DescendenteAscendente:
                    livros = livros.OrderByDescending(e => e.Edicao).ThenByDescending(a => a.Autor).ThenBy(t => t.Titulo).ToList();
                    break;
            }
            return livros;
        }

        private async Task<List<Livro>> OrdenarPorAutorTitulo(List<Livro> livros, MetodoOrdenacao metodoOrdenacao)
        {
            switch (metodoOrdenacao)
            {
                case MetodoOrdenacao.AscendenteDescendente:
                    livros = livros.OrderBy(a => a.Autor).ThenByDescending(t => t.Titulo).ToList();
                    break;
                case MetodoOrdenacao.DescendenteAscendente:
                    livros = livros.OrderByDescending(a => a.Titulo).ThenBy(a => a.Autor).ToList();
                    break;
            }
            return livros;
        }

        private async Task<List<Livro>> OrdenarPorEdisao(List<Livro> livros, MetodoOrdenacao metodoOrdenacao)
        {
            switch (metodoOrdenacao)
            {
                case MetodoOrdenacao.Ascendente:
                    livros = livros.OrderBy(a => a.Edicao).ToList();
                    break;
                case MetodoOrdenacao.Descendente:
                    livros = livros.OrderByDescending(a => a.Edicao).ToList();
                    break;
            }
            return livros;
        }

        private async Task<List<Livro>> OrdenarPorTitulo(List<Livro> livros, MetodoOrdenacao metodoOrdenacao)
        {
            switch (metodoOrdenacao)
            {
                case MetodoOrdenacao.Ascendente:
                    livros = livros.OrderBy(a => a.Titulo).ToList();
                    break;
                case MetodoOrdenacao.Descendente:
                    livros = livros.OrderByDescending(a => a.Titulo).ToList();
                    break;
            }
            return livros;
        }

        private async Task<List<Livro>> OrdenarPorAutor(List<Livro> livros, MetodoOrdenacao metodoOrdenacao)
        {
            switch (metodoOrdenacao)
            {
                case MetodoOrdenacao.Ascendente:
                    livros = livros.OrderBy(a => a.Autor).ToList();
                    break;
                case MetodoOrdenacao.Descendente:
                    livros = livros.OrderByDescending(a => a.Autor).ToList();
                    break;
            }
            return livros;
        }
    }
}
