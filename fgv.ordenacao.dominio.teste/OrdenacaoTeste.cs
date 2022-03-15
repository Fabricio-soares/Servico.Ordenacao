using fgv.ordenacao.dominio.Interface;
using fgv.ordenacao.dominio.Util;
using Moq;
using Xunit;

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

    }
}
