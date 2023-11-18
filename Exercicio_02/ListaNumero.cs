
namespace Exercicio_02
{
    public class ListaNumeros
    {
        public List<int> Numeros { get; private set; }

        public ListaNumeros()
        {
            Numeros = new List<int>();
        }

        public void AdicionarNumero(int numero)
        {
            Numeros.Add(numero);
        }
    }

    public static class ListaNumerosExtensions
    {
        public static int CalcularSoma(this ListaNumeros lista)
        {
            return lista.Numeros.Sum();
        }

        public static double CalcularMedia(this ListaNumeros lista)
        {
            if (lista.Numeros.Count == 0)
                return 0;

            return lista.Numeros.Average();
        }
    }
}