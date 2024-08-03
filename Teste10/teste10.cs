using System;
//ESTRUTURA CONDICIONAL IF ELSE 
namespace Teste10
{
    class Teste10
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,n4,res;

            Console.Write("digite o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("digite o segundo valor: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("digite o terceiro valor: ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("digite o quarto valor: ");
            n4 = int.Parse(Console.ReadLine());

            res = (n1+n2+n3+n4)/4;

            if(res < 4){
                Console.WriteLine("Reprovado");
            }else if(res < 6){
                Console.WriteLine("Recuperação");
            }else{
                Console.WriteLine("Aprovado");
            }
            // int nota;

            // Console.Write("Digite a nota: ");
            // nota = int.Parse(Console.ReadLine());

            // if(nota>=60){
            //     Console.WriteLine("Aprovado");
            // }else{
            //     Console.WriteLine("Reprovado");
            // }

            // int nota=80;
            // string resultado = "Reprovado";

            // if(nota>=60){
            //     resultado = "Aprovado";
            // }
            // Console.WriteLine("resultado: {0}", resultado);
        }
    }
}
