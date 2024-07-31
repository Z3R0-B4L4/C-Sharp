using System;
//ARGUMENTOS DE ENTRADA
namespace Teste46
{

    class Teste46
    {
        static void Main(string[] args)
        {
            int r=0;

            if(args.Length > 0){
                Console.WriteLine("Qtde de argumentos: {0}",args.Length);
                for(int i = 0; i < args.Length; i++){
                    r+=int.Parse(args[i]);
                    //Console.WriteLine("Argumento {0}: {1}",i,args[i]);
                }
                Console.WriteLine("Soma: {0}",r);
            }else{
                Console.WriteLine("Nenhum argumento foi passado");
            }
            
        }   
    }
}