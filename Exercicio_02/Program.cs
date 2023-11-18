using Exercicio_02;

class Program
{
    static void Main()
    {
        ListaNumeros minhaLista = new ListaNumeros();

        minhaLista.AdicionarNumero(10);
        minhaLista.AdicionarNumero(20);
        minhaLista.AdicionarNumero(30);

        //soma e a média
        int soma = minhaLista.CalcularSoma();
        double media = minhaLista.CalcularMedia();

        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Média: {media}");
    }
}