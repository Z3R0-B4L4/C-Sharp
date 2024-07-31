using System;
//TRY CATCH FINALLY
namespace Teste47
{

    class Area{
        public static double Quad(double b, double a){
            if(b==0 || a==0){
                throw new Exception("Base ou altura não podem ser 0");
            }else{
                return b*a;
            }
            
        }
    }

    class Teste47
    {
        static void Main(string[] args)
        {
            // int a,b,r;
            double area;

            // a=10;
            // b=0;


            // try
            // {
            //     r=a/b;
            //     Console.WriteLine("{0}/{1}={2}",a,b,r);
            //     throw new Exception("Teste");
            // }
            // catch(Exception e)
            // {
            //     Console.WriteLine("Erro: {0}",e.Message);
            //     Console.WriteLine("Stack: {0}",e.StackTrace);
            //     Console.WriteLine("Source: {0}",e.GetType().Name);
            //     Console.WriteLine("Source: {0}",e.GetType());
            // }
            // finally
            // {
            //     Console.WriteLine("Fim");
            // }


            try{
                area = Area.Quad(10,0);
                Console.WriteLine("Area: {0}",area);
            }catch(Exception e){
                Console.WriteLine("Erro: {0}",e.Message);
                Console.WriteLine("Source: {0}",e.GetType().Name);
                Console.WriteLine("Source: {0}",e.GetType());
            }
        }
    }
}