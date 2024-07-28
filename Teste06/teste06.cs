using System;

namespace Teste05
{
    class Teste05
    {
        static void Main(string[] args)
        {
            int v1,v2,soma;
            string nome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine(); //Console.ReadLine() = ler o que o usuario digitar
            Console.Write("Digite o primeiro valor: ");
            v1 = int.Parse(Console.ReadLine()); //int.Parse = converte string para inteiro
            Console.Write("Digite o segundo valor: ");
            v2 = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32 = converte string para inteiro

            //int.Parse e Convert.ToInt32 fazem a mesma coisa
            soma=v1+v2;
            Console.WriteLine("{0} a soma dos valores digitados é: {1}", nome, soma);

        }
    }
}