using fgv.ordenacao.dominio.Entidades;
using fgv.ordenacao.dominio.Util;
using FluentAssertions;
using System;
using Xunit;

namespace fgv.ordenacao.dominio.teste
{
    public class LivroTeste
    {

        [Fact]
        public void CriandoLivro_AutorInexistente_erro()
        {
            Action action = () => new Livro("Livro 4", "", "Internet & World Wide Web: How to Program", "2007");
            action.Should().Throw<OrdenacaoException>();
        }

    }
}
