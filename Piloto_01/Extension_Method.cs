using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Piloto_01
{
    public static class Extension_Method
    {
        // Exemplo 01 : Extension Method Para Strings - Inverter a String
        public static string Inverter(this string texto)
        {
                char[] caracteres = texto.ToCharArray();
                Array.Reverse(caracteres);
                return new string(caracteres);
        }
            // Exemplo 02: Extension method para List <int> Calcular Media
        public static double CalcularMedia(this List<int> numeros)
        {
                return numeros.Sum() / (double)numeros.Count();
        }
        

    }
}