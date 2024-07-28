using System;
//LOOP FOREACH
namespace Teste18
{
    class Teste18
    {
        static void Main(string[] args)
        {
            int[] num = new int[3]{10,20,30};

            for(int i = 0; i < num.Length; i++){
                num[i]=0;
            }

            foreach(int n in num){ //foreach ('tipo' 'variavel' in 'coleção') é indicado para a leitura dos elementos de uma coleção
                Console.WriteLine(n);
            }
        }
    }
}