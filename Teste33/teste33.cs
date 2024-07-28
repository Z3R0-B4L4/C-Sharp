using System;
//HERANÇA / ORDEM DE EXECUÇÃO DE CONSTRUTORES
//ORDEM É DA BASE PARA AS DERIVADAS
namespace Teste33
{

    class Base
    {
        public Base(){
            Console.WriteLine("Construtor da classe base");
        }
    }

    class Derivada1:Base
    {
        public Derivada1(){
            Console.WriteLine("Construtor da classe derivada1");
        }
    }

    class Derivada2:Derivada1
    {
        public Derivada2(){
            Console.WriteLine("Construtor da classe derivada2");
        }
    }

    class Teste33
    {
        static void Main(string[] args)
        {
            Derivada2 d2 = new Derivada2();
        }
    }
}