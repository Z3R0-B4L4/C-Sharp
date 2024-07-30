using System;
//RECURSIVIDADE
//função que chama ela mesma
namespace Teste44
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

        public int fat(int n){
            int r;
            if(n<=1){
                r = 1;
            }else{
                r = n*fat(n-1);
            }
            return r;
        }
    }

    class Teste44
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            int res = c.fat(5);
            //double res = c.soma(10.9,20.5,53.8+95.7-23.5);
            //Console.WriteLine("Soma = {0}",res);
            Console.WriteLine("Fatorial = {0}",res);
        }
    }
}
