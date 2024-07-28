using System;
//LOOP FOR
namespace Teste15
{
    class Teste15
    {
        static void Main(string[] args)
        {           
            // for(int num = 0; num <= 10; num++){ //for = estrutura de repeticão ('Contador';'Condicao';'Incremento' ou 'Decremento')
            //     Console.WriteLine(num);
            // }


            int[] num = new int[10];

            for(int i = 0; i < num.Length; i++){ //num.Length = tamanho do array, para que não ocorra um erro de indice inválido durante a execução do programa, o erro seria colocar um valor maior que o tamanho do array que é 10 (0 a 9)
                num[i]=0;
            }

            for(int i = 0; i < 10; i++){
                Console.WriteLine("Valor de num na posicao {0}: {1}",i,num[i]);
            }
        }
    }
}