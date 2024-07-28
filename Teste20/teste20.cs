using System;
//MÉTODOS
namespace Teste20
{
    class Teste20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());
            int r = soma(n1,n2);//quando um método tem retorno, esse retorno tem que ser atribuído a uma variável quando o método for chamado
            Console.WriteLine("A soma de {0} + {1} = {2}",n1,n2,r);
        }

        static void teste(){ //void = método que não tem retorno
            Console.WriteLine("teste");
            Console.WriteLine("Testes de C#");
            Console.WriteLine("Eduardo");
        }

        
        static int soma(int num1, int num2){ //métodos podem receber diferentes tipos de parâmetros ex: (int, string, double, float...)
            int res = num1 + num2;
            return res;
        }

    }
}