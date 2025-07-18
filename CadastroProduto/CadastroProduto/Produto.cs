using System.Globalization;
namespace CadastroProduto
{
    internal class Produto
    {
        //Variaveis
        public string Nome {  get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }


        //Construtores
        public Produto(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"Nome do produto: {Nome}, Preço do produto: $ {Preco.ToString("F2", CultureInfo.InvariantCulture
                )}, Quantidade do Produto: {Quantidade}";
        }
    }
}
