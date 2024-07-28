using System;
//THIS
namespace Teste28
{

    class Calculos{
        public int v1;
        public int v2;

        public Calculos(int v1, int v2){
            this.v1 = v1; //this = serve para referenciar o atributo da classe
            this.v2 = v2;
        }
        public int Somar(){
            return v1+v2;
        }
    }
    class Teste28
    {
        static void Main(string[] args)
        {
            Calculos c = new Calculos(5,10);
            Console.WriteLine(c.Somar());
        }
    }
}