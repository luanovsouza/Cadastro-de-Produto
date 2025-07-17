using System.Globalization;
namespace CadastroProduto
{
    internal class Produto
    {
        public Produto()
        {
        }

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
    }
}
