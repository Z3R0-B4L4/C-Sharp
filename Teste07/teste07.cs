using System;

namespace Teste07
{
    class Teste07
    {
        static void Main(string[] args)
        {
            //operadores bitwise
            int num = 10;
            num=num<<1; // << = deslocamento para esquerda e dobra o valor / >> = deslocamento para direita e divide o valor por 2
            //num=num>>1;
            Console.WriteLine(num);
        }
    }
}