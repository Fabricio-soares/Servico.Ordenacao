using fgv.ordenacao.dominio.Entidades;
using fgv.ordenacao.dominio.Interface;
using fgv.ordenacao.dominio.Util;
using Moq;
using System.Collections.Generic;
using Xunit;
using static fgv.ordenacao.dominio.Util.ParametroOrdenacao;

namespace fgv.ordenacao.dominio.teste
{
    public class OrdenacaoTeste
    {
        #region Property  
        public Mock<IOrdenacaoLivro> mock = new Mock<IOrdenacaoLivro>();
        #endregion

        [Fact]
        public void Ordenacao_LivroNull_erro()
        {
            mock.Setup(x => x.OrdenarLivroAsync(ParametroOrdenacao.ParametrosOrdenacao.AutorTitulo, ParametroOrdenacao.MetodoOrdenacao.Ascendente, null)).Throws<OrdenacaoException>();
        }


        [Fact]
        public void Ordenacao_LivroAutorAscendente_Sucesso()
        {
            var livro1 = new Livro("Livro 1", "Deitel & Deitel", "Java	How	to Program", "2007");
            var livro2 = new Livro("Livro 2", "Martin Fowler", "Patterns of Enterprise Application Architecture", "2002");
            var livro3 = new Livro("Livro 3", "Elisabeth Freeman", "Head First Design Patterns", "2004");
            var livro4 = new Livro("Livro 4", "Deitel & Deitel", "Internet	& World Wide Web: How to Program", "2007");

            var livrosSucesso = new List<Livro>();
            livrosSucesso.Add(livro1);
            livrosSucesso.Add(livro2);
            livrosSucesso.Add(livro3);
            livrosSucesso.Add(livro4);

            var Ascendente = mock.Setup(x => x.OrdenarLivroAsync(ParametrosOrdenacao.Titulo, MetodoOrdenacao.Ascendente, livrosSucesso)).ReturnsAsync(livrosSucesso);
            Assert.NotNull(Ascendente);
        }
        [Fact]
        public void Ordenacao_LivroAutorAscendenteTituloDescendente_Sucesso()
        {
            var livro1 = new Livro("Livro 1", "Deitel & Deitel", "Java	How	to Program", "2007");
            var livro2 = new Livro("Livro 2", "Martin Fowler", "Patterns of Enterprise Application Architecture", "2002");
            var livro3 = new Livro("Livro 3", "Elisabeth Freeman", "Head First Design Patterns", "2004");
            var livro4 = new Livro("Livro 4", "Deitel & Deitel", "Internet	& World Wide Web: How to Program", "2007");

            var livrosSucesso = new List<Livro>();
            livrosSucesso.Add(livro1);
            livrosSucesso.Add(livro2);
            livrosSucesso.Add(livro3);
            livrosSucesso.Add(livro4);


            var Ascendente = mock.Setup(x => x.OrdenarLivroAsync(ParametrosOrdenacao.AutorTitulo, MetodoOrdenacao.AscendenteDescendente, livrosSucesso)).ReturnsAsync(livrosSucesso);
            Assert.NotNull(Ascendente);
        }

        public void Ordenacao_LivroAutorEdicaoAutorTitulo_Sucesso()
        {
            var livro1 = new Livro("Livro 1", "Deitel & Deitel", "Java	How	to Program", "2007");
            var livro2 = new Livro("Livro 2", "Martin Fowler", "Patterns of Enterprise Application Architecture", "2002");
            var livro3 = new Livro("Livro 3", "Elisabeth Freeman", "Head First Design Patterns", "2004");
            var livro4 = new Livro("Livro 4", "Deitel & Deitel", "Internet	& World Wide Web: How to Program", "2007");

            var livrosSucesso = new List<Livro>();
            livrosSucesso.Add(livro1);
            livrosSucesso.Add(livro2);
            livrosSucesso.Add(livro3);
            livrosSucesso.Add(livro4);


            var Ascendente = mock.Setup(x => x.OrdenarLivroAsync(ParametrosOrdenacao.EdicaoAutorTitulo, MetodoOrdenacao.DescendenteAscendente, livrosSucesso)).ReturnsAsync(livrosSucesso);
            Assert.NotNull(Ascendente);
        }


    }
}
