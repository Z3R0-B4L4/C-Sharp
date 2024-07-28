using System;

namespace teste09
{

    class teste09
    {
        static void Main(string[] args)
        {
            // int n1=10;
            // float n2=n1; //conversao implicita

            // float n1=10.5f;
            // int n2 = (int)n1; //conversao explicita - typecasting

            int vInt = 10;
            short vShort = (short)vInt; //conversao explicita - typecasting

            Console.WriteLine(vShort);
        }
    }
}