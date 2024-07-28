using System;
//PASSAGEM POR REFERENCIA
namespace Teste21
{

    class Teste21
    {
        static void Main(string[] args)
        {
            int num = 10;
            dobrar(ref num); //passando o valor por referencia
            Console.WriteLine("valor dobrado: {0}",num);
        }

        static void dobrar(ref int valor){ //ref = indica que o valor será passado por referencia
            valor*=2;
        }
    }
}