using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine("Ente os dados do produto:");

            p.Nome = "TV 4K";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

            //Console.Write("Preço: ");

            //Console.WriteLine("Dados dos produtos:");

            //Console.Write("Digite o número de produtos a ser adicionados: ");

            //Console.WriteLine("Dados atualizados: " + p);

            //Console.Write("Digite o número de produtos a ser removidos: ");

            //Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
