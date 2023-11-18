using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{    //classe produto I
    public class Produto
    {
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public string? Descricao { get; set; }
    }

    // extensao do metodo para imprimir detalhes do produto II
    public static class ExtensionMethods
    {
        public static string ImprimirDetalhes(this Produto produto)
        {
            return $"Nome: {produto.Nome}\nPreço: {produto.Preco:C}\nDescrição: {produto.Descricao}";
        }
        // extensao do metodo para aplicar desconto III
        public static double AplicarDesconto(this Produto produto, double percentualDesconto)
        {
            double desconto = produto.Preco * (percentualDesconto / 100);
            return produto.Preco - desconto;
        }
    }

}