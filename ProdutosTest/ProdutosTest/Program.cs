using System;
using System.Globalization;

namespace ProdutosTest {
    class Program {
        static void Main(string[] args) {
            Produto p1 = new Produto();

            Console.WriteLine("Coloque os dados do produto");
            Console.WriteLine("Nome do produto");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Preco do produto");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade do produto");
            p1.Quant = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados produto: {0}", p1);

            Console.WriteLine();
            Console.WriteLine("Digite quantas unidades você vai adicionar ao estoque: ");
            int qntd = int.Parse(Console.ReadLine());
            p1.AdicionarUnid(qntd);
            Console.WriteLine("Dados produto: {0}", p1);

            Console.WriteLine();
            Console.WriteLine("Digite quantas unidades você vai remover do estoque: ");
            qntd = int.Parse(Console.ReadLine());
            p1.RemoverUnid(qntd);
            Console.WriteLine("Dados produto: {0}", p1);

        }
    }
}