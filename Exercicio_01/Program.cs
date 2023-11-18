using Exercicio_01;

class Program
{   // metodo main IV
    static void Main()
    {
        // produto
        Produto meuProduto = new Produto
        {
            Nome = "redbull",
            Preco = 9.00,
            Descricao = "energetico que te da asas"
        };

        // detalhe do produto
        Console.WriteLine("Detalhes do Produto:\n" + meuProduto.ImprimirDetalhes());

        // desconto
        double percentualDesconto = 5.0;
        double precoComDesconto = meuProduto.AplicarDesconto(percentualDesconto);

        // final
        Console.WriteLine($"\nDetalhes do Produto com {percentualDesconto}% de desconto:\n" +
                          $"Preço com desconto: {precoComDesconto:C}");
    }
}