using System;
//SOBRECARGA DE METODOS
namespace Teste43
{

    class Calc{

        public int soma(int a, int b){
            return a+b;
        }

        public double soma(double a, double b){
            return a+b;
        }

        public double soma(params double[]n){
            double r = 0;
            for(int i = 0; i < n.Length; i++){
                r += n[i];
            }
            return r;
        }
    }

    class Teste43
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            double res = c.soma(10.9,20.5,53.8+95.7-23.5);
            Console.WriteLine("Soma = {0}",res);
        }
    }
}