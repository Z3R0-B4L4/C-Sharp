using System;
//ARGUMENTO OUT
namespace Teste22
{

    class Teste22
    {
        static void Main(string[] args)
        {
            int dividendo, divisor, quociente, r;
            Console.WriteLine("digite o dividendo: ");
            dividendo = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o divisor: ");
            divisor = int.Parse(Console.ReadLine());
            quociente = divide(dividendo,divisor,out r); //out = indica que o valor será passado por referencia e deve ser atribuído a uma variável existente
            Console.WriteLine("quociente: {0} resto: {1}",quociente,r);

        }

        static int divide(int dividendo, int divisor,out int resto){ //out = indica que o valor será passado por referencia, assim retornando mais de um valor (quociente é o return padrão do método e o resto é o out)
            int quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
        }
        
    }
}