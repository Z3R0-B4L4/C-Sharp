using System;

namespace Teste04
{

    class Teste04
    {
        static void Main(string[] args)
        {
            double valorCompra=5.5;
            double valorVenda;
            double lucro=0.1;
            string produto="Pastel";

            valorVenda = valorCompra * (valorCompra*lucro);
            //\t = tab \n = quebra de linha
            Console.WriteLine("Produto.......:{0,15}",produto);
            Console.WriteLine("Val.Compra....:{0,15:c}",valorCompra);
            Console.WriteLine("Lucro.........:{0,15:p}",lucro);
            Console.WriteLine("Val.Venda.....:{0,15:c}",valorVenda);
            //p = porcentagem e c = centavos

        }
    }
}