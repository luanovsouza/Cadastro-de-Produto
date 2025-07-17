using System.Globalization;
namespace CadastroProduto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto produto;

            while (true)
            {
                Console.Write("Digite o nome do Produto: ");
                string? nome = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Digite o Preço do Produto: ");
                double preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Console.Write("Digite a quantidade do Produto para o estoque: ");
                double quantidade = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
            }
        }
    }
}