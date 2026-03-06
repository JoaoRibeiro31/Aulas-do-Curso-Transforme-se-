using System;
using System.Globalization;

namespace Exercicio-Lista(LINQ)

{

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>()
            {
                   new Produto{ Nome="Notebook",        Categoria="Eletrônicos", Preco=3500,  Estoque=10 },
                   new Produto{ Nome="Mouse",           Categoria="Eletrônicos", Preco=80,    Estoque=50 },
                   new Produto{ Nome="Teclado",         Categoria="Eletrônicos", Preco=150,   Estoque=40 },
                   new Produto{ Nome="Cadeira Gamer",   Categoria="Móveis",      Preco=1200,  Estoque=5 },
                   new Produto{ Nome="Mesa Escritório", Categoria="Móveis",      Preco=900,   Estoque=8 },
                   new Produto{ Nome="Monitor",         Categoria="Eletrônicos", Preco=1100,  Estoque=12 },
                   new Produto{ Nome="Luminária",       Categoria="Decoração",   Preco=120,   Estoque=25 }
            };

            // Exercício(LINQ)


           //Uma Loja Possui uma lista de produtos cadastrados.
           //Cada produto possui as seguintes informações:

           //  Nome
           //  Categoria
           //  Preço
           //  Quantidade em Estoque

           //Usando LINQ, realize algumas consultas e análises sobre a lista.

           //1.Mostre todos os produtos que custam mais de R$ 1000
           //2.Liste apenas os nomes dos produtos da categoria Eletrônicos.
           //3.Mostre os produtos ordenados do mais barato para o mais caro.
           //4.Calcule o valor médio dos produtos
           //5.Encontre o produto mais caro
           //6.Mostre todos os produtos que possuem estoque menor que 10
           //7.Calcule o valor total do estoque da loja
           //8.Agrupe produtos por categoria.

          //Métodos utilizados:
          //-Where
          //- OrderBy
          //- Sum
          //- Average
          //- Max
          //- GroupBy




          //Mostrar somente produtos acima de R$1000
          var produtosMaiorqueMil = produtos.Where(p => p.Preco > 1000);
          foreach (var p in produtosMaiorqueMil)
          {
              Console.WriteLine("R$" + p.Preco);
          }

          //Mostrar Categoria Eletrônicos
          var eletronicos = produtos.Where(e => e.Categoria == "Eletrônicos");
          foreach (var ele in eletronicos)
          {
              Console.WriteLine(ele.Nome);
          }

          //Produtos ordenados do menor ao maior
          var crescente = produtos.OrderBy(c => c.Preco);
          foreach (var c in crescente)
          {
              Console.WriteLine("R$" + c.Preco);
          }

          //media 
          double media = produtos.Average(c => c.Preco);
          string mediaFormatada = media.ToString("C0", new CultureInfo("pt-BR"));
          Console.WriteLine(mediaFormatada);

          //Produto mais caro
          var caro = produtos.Max(n => n.Preco);
          Console.WriteLine("R$" + caro);

          //Estoque menor que 10
          var estoque = produtos.Where(e => e.Estoque <= 10);
          foreach (var e in estoque)
          {
              Console.WriteLine(e.Estoque);
          }

          //Valor total do estoque
          var vtEstoque = produtos.Sum(e => e.Estoque);
          Console.WriteLine(vtEstoque);

          //Agrupar produtos por categoria
          var aguparCategoria = produtos.GroupBy(e => e.Categoria);
          foreach (var a in aguparCategoria)
          {
              Console.WriteLine(a.Key);
              foreach (var produto in a)
              {
                  Console.WriteLine($" - {produto.Nome} (R$ {produto.Preco}");
              }
          }
        }
           class Produto
           {
            public string Nome { get; set; }
            public string Categoria { get; set; }
            public double Preco { get; set; }
            public int Estoque { get; set; }
           }
    
    }
}


