using fgv.ordenacao.dominio.Entidades;
using fgv.ordenacao.dominio.Interface;
using fgv.ordenacao.ioc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using static fgv.ordenacao.dominio.Util.ParametroOrdenacao;

namespace fgv.ordenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int order = 1;
            var service = new ServiceCollection();
            service.ConfigureService();
            var serviceProvider = service.BuildServiceProvider();


            var livro1 = new Livro("Livro 1", "Deitel & Deitel", "Java	How	to Program", "2007");
            var livro2 = new Livro("Livro 2", "Martin Fowler", "Patterns of Enterprise Application Architecture", "2002");
            var livro3 = new Livro("Livro 3", "Elisabeth Freeman", "Head First Design Patterns", "2004");
            var livro4 = new Livro("Livro 4", "Deitel & Deitel", "Internet	& World Wide Web: How to Program", "2007");

            var livrosSucesso = new List<Livro>();
            livrosSucesso.Add(livro1);
            livrosSucesso.Add(livro2);
            livrosSucesso.Add(livro3);
            livrosSucesso.Add(livro4);

            var livrosVazio = new List<Livro>();


            var ordenacaoAscendente = serviceProvider.GetService<IOrdenacaoLivro>();
            var LivroTituloAscendente = ordenacaoAscendente.OrdenarLivroAsync(ParametrosOrdenacao.Titulo, MetodoOrdenacao.Ascendente, livrosSucesso).Result;
            var LivroAutorAscendenteTituloDescendente = ordenacaoAscendente.OrdenarLivroAsync(ParametrosOrdenacao.AutorTitulo, MetodoOrdenacao.AscendenteDescendente, livrosSucesso).Result;
            var LivroAutorEdicaoAutorTitulo = ordenacaoAscendente.OrdenarLivroAsync(ParametrosOrdenacao.EdicaoAutorTitulo, MetodoOrdenacao.DescendenteAscendente, livrosSucesso).Result;


            Console.WriteLine($"--------------------------------Titulo Ascendente-------------------------------------------");
            foreach (var livro in LivroTituloAscendente)
            {
                Console.WriteLine($"Ordem: {order.ToString()} | Livro: {livro.OrdemDescricao} | Autor: {livro.Autor} | Titulo: {livro.Titulo} | Edisao: {livro.Edicao}");
                order++;
            }
            Console.WriteLine($"-------------------------------------------------------------------------------------------");

            order = 1;
            Console.WriteLine($"--------------------------------Autor Ascendente e Titulo Descendente-----------------------");
            foreach (var livro in LivroAutorAscendenteTituloDescendente)
            {
                Console.WriteLine($"Ordem: {order.ToString()} | Livro: {livro.OrdemDescricao} | Autor: {livro.Autor} | Titulo: {livro.Titulo} | Edisao: {livro.Edicao}");
                order++;
            }
            Console.WriteLine($"-------------------------------------------------------------------------------------------");


            order = 1;
            Console.WriteLine($"--------------------------------Autor e Edicao Descendente e Titulo Ascendente--------------");
            foreach (var livro in LivroAutorEdicaoAutorTitulo)
            {
                Console.WriteLine($"Ordem: {order.ToString()} | Livro: {livro.OrdemDescricao} | Autor: {livro.Autor} | Titulo: {livro.Titulo} | Edisao: {livro.Edicao}");
                order++;
            }
            Console.WriteLine($"-------------------------------------------------------------------------------------------");

            order = 1;
            Console.WriteLine($"--------------------------------Não há livros para ordenar--------------");
            var LivroVazio = ordenacaoAscendente.OrdenarLivroAsync(ParametrosOrdenacao.EdicaoAutorTitulo, MetodoOrdenacao.DescendenteAscendente, livrosVazio).Result;
            Console.WriteLine($" Quantidade de livros : {LivroVazio.Count}");
            Console.WriteLine($"-------------------------------------------------------------------------------------------");



            Console.WriteLine($"--------------------------------Livro null--------------");
            try
            {
                var LivroNull = ordenacaoAscendente.OrdenarLivroAsync(ParametrosOrdenacao.EdicaoAutorTitulo, MetodoOrdenacao.DescendenteAscendente, null).Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Exception {ex.Message}. ");
            }
            Console.WriteLine($"-------------------------------------------------------------------------------------------");
 

            Console.ReadLine();
        }
    }
}
