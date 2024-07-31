using System;
//NAMESPACE
//Serve para agrupar classes e objetos dentro de um mesmo contexto
namespace Calc{
    class Area{
        public static double Quad(double b, double a){
            if(b==0 || a==0){
                throw new Exception("Base ou altura não podem ser 0");
            }else{
                return b*a;
            }
            
        }
    }
}

namespace Teste48
{
    class Teste47
    {
        static void Main(string[] args)
        {

            double area;

            try{
                area = Calc.Area.Quad(10,0);
                Console.WriteLine("Area: {0}",area);
            }catch(Exception e){
                Console.WriteLine("Erro: {0}",e.Message);
                Console.WriteLine("Source: {0}",e.GetType().Name);
                Console.WriteLine("Source: {0}",e.GetType());
            }
        }
    }
}
