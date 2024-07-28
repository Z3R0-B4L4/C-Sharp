using System;
//MÉTODOS VIRTUAIS
//Métodos virtuais são métodos que possuem o mesmo nome do método padrão da classe base mas que executam uma função diferente, métodos virtuais podem ser sobrescritos
namespace Teste34
{

    class Base
    {
        public Base(){
            Console.WriteLine("Construtor da classe base");
        }

        virtual public void info(){
            Console.WriteLine("Classe base");
        }


    }

    class Derivada1:Base
    {
        public Derivada1(){
            Console.WriteLine("Construtor da classe derivada1");
        }

        override public void info(){ //override: sobrescreve o método da classe base
            Console.WriteLine("Classe derivada 1");
        }
    }

    class Derivada2:Derivada1
    {
        public Derivada2(){
            Console.WriteLine("Construtor da classe derivada2");
        }

        override public void info(){ //override: sobrescreve o método da classe base (Derivada1)
            Console.WriteLine("Classe derivada 2");
        }
    }

    class Teste34
    {
        static void Main(string[] args)
        {
            Base Ref; 
            Derivada1 d1 = new Derivada1();
            Derivada2 d2 = new Derivada2();
            Ref = d1; 
            Ref.info();
            
        }
    }
}