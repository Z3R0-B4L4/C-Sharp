using System;
//ARRAYS UNIDIMENSIONAIS / VETORES
namespace Teste13
{
    class Teste13
    {
        static void Main(string[] args)
        {
            int[] n = new int[5]; //declara um array e o indice vai de 0 a 4 (indice sempre começa em 0)
            int[] num = new int[3]{10,20,30}; //declara um array e seus respectivos valores
            int[] num2 = {9,19,29};//declara um array e seus respectivos valores sem o new, a diferença deste para os outros é que o tamanho do array é determinado pela quantidade de valores

            n[0]=111;
            n[1]=222;
            n[2]=333;
            n[3]=444;
            n[4]=555;

            Console.WriteLine("Indice: {0}",n[0]); //n[0] escrevera no console o valor da posição 0 do array
            Console.WriteLine("Indice: {0}",num[0]);
            Console.WriteLine("Indice: {0}",num2[0]);
        }
    }
}
