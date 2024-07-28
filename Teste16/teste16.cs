using System;
//LOOP WHILE
namespace Teste16
{
    class Teste16
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            int i = 0;
            while(i<num.Length){ //diferente do for, o while não tem um 'indice', ele tem uma condicional e uma operação que vai ser repetida enquanto essa condicional for verdadeira e não pode criar uma variável dentro do seu '()'
                num[i]=0;
                Console.WriteLine(num[i]);
                i++;
            }
            Console.WriteLine("Fim");
            
        }
    }
}