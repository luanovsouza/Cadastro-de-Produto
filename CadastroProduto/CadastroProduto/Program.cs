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
                Console.WriteLine("Olá bem vindo ao sistema de cadastro de produtos!");
                Console.WriteLine("---------------------");
                Console.WriteLine();

                Console.Write("Digite o nome do Produto: ");
                string? nome = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Digite o Preço do Produto: ");
                double preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Console.Write("Digite a quantidade do Produto para o estoque: ");
                int quantidade = Convert.ToInt16(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                produto = new Produto(nome, preco, quantidade);

                Console.WriteLine("-----------------------");
                Console.WriteLine("Oque você de seja agora?");
                Console.WriteLine();

                Console.WriteLine("1 - Adicionar no estoque: \n");
                Console.WriteLine("2 - Remover do estoque: \n");
                Console.WriteLine("3 - Mostrar estoque: \n");
                Console.WriteLine("4 - Salvar e sair: \n");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        produto.AdicionarProduto(quantidade);
                        Console.WriteLine("Voce adicionou um produto ao estoque parabens!");
                        Console.WriteLine();
                        break;
                    case "2":
                        produto.RemoverProduto(quantidade);
                        Console.WriteLine("Voce removeu um produto ao estoque parabens!");
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine("Aqui esta o estoque: ");
                        Console.WriteLine(produto.ToString());
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine("Ok, saindo...");
                        return;
                }
            }
        }
    }
}