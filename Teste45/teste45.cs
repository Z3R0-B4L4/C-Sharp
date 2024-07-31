using System;
//DELEGATE
//Em C#, um delegate é uma maneira segura de encapsular chamadas de métodos. Ele permite tratar métodos como variáveis de primeira classe, ou seja, você pode passá-los por ali como variáveis, armazená-los em coleções e invocá-los dinamicamente.
namespace Teste45
{

    delegate int Op(int a, int b);

    class Mat{
        public static int soma(int a, int b){
            return a+b;
            }


        public static int mult(int a, int b){
            return a*b;
        }
    }

    class Teste45
    {
        static void Main(string[] args)
        {
            int r;
            Op d1 = new Op(Mat.soma);

            r = d1(10,20);
            Console.WriteLine(r);

            d1 = new Op(Mat.mult);
            r = d1(2,32);
            Console.WriteLine(r);
        }
    }
}