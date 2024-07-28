using System;
//SEALED
namespace Teste36
{
    sealed class Veiculo{//classe sealed nao pode ser herdada

    }



    class Carro : Veiculo{//erro, classe sealed não pode ser herdada
        
    }

    class Teste36
    {
        static void Main(string[] args)
        {
            Veiculo v = new Veiculo();
            //v = new Carro(); //erro, classe sealed não pode ser herdada

        }
    }
}