using System;

namespace Teste08
{
    class Teste08
    {

        enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado}; //enum = enumerador que serve para definir um conjunto de constantes

        static void Main(string[] args)
        {
            //DiasSemana ds = DiasSemana.Domingo;
            DiasSemana ds = (DiasSemana)3; //cast = converte um tipo em outro
            //int ds = (int)DiasSemana.Sexta; //converte um tipo em outro e retorna um inteiro (neste caso o valor do indice)
            Console.WriteLine(ds);
        }
    }
}