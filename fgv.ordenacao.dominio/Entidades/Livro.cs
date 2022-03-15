using fgv.ordenacao.dominio.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace fgv.ordenacao.dominio.Entidades
{
    public class Livro
    {
        public string OrdemDescricao { get; set; }
        public string Autor { get; set; }

        public string Titulo { get; set; }
        public string Edicao { get; set; }

        public Livro()
        {
                
        }

        public Livro(string ordemDescricao, string autor, string titulo, string edicao)
        {
            ValidacaoEntidade(ordemDescricao,autor, titulo, edicao);
            this.OrdemDescricao = ordemDescricao;
            this.Autor = autor;
            this.Titulo = titulo;
            this.Edicao = edicao;
        }

        public void ValidacaoEntidade(string ordemDescricao, string autor, string titulo, string edicao)
        {
            if (string.IsNullOrWhiteSpace(autor))
                throw new OrdenacaoException("Não é possível ordenar livro com o nome do autor vazio.");
            if(string.IsNullOrWhiteSpace(titulo))
                throw new OrdenacaoException("Não é possível ordenar livro com o titulo vazio.");
            if (string.IsNullOrWhiteSpace(edicao))
                throw new OrdenacaoException("Data de edição inconsistente.");
        }
    }
}
