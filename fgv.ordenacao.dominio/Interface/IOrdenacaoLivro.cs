using fgv.ordenacao.dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;
using static fgv.ordenacao.dominio.Util.ParametroOrdenacao;

namespace fgv.ordenacao.dominio.Interface
{
    public interface IOrdenacaoLivro
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modoOrdenacaoLivro"></param>
        /// <param name="livros"></param>
        /// <returns></returns>
        Task<List<Livro>> OrdenarLivroAsync(ParametrosOrdenacao  parametrosOrdenacao,MetodoOrdenacao metodoOrdenacao, List<Livro> livros);

    }
}
