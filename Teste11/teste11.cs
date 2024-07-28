using System;
//SWITCH CASE
namespace Teste11
{

    class Teste11
    {
        static void Main(string[] args)
        {
            int tempo,escolha;
            Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
            Console.WriteLine("Escolha o transporte: [1]Aviao, [2]Carro, [3]Navio");
            escolha = int.Parse(Console.ReadLine());

            switch(escolha){ //switch compara uma variavel com um conjunto de constantes (Não esquecer de colocar o break)
                case 1:
                    tempo = 50;
                    break;
                case 2:
                    tempo = 100;
                    break;
                case 3:
                    tempo = 200;
                    break;
                default: //caso o valor da variavel seja diferente de todas as constantes o switch vai para o default
                    tempo = -1;
                    break;

            }

            if(tempo<0){
                Console.WriteLine("Transporte indisponível");
            }else{
                Console.WriteLine("tempo estimado: {0} minutos", tempo);
            }


            // int tempo;
            // char escolha;
            // Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
            // Console.WriteLine("Escolha o transporte: [a]Aviao, [b]Carro, [c]Navio");
            // escolha = char.parse(Console.ReadLine());

            // switch(escolha){
            //     case 'a':
            //     case 'A':
            //         tempo = 50;
            //         break;
            //     case 'b':
            //     case 'B':
            //         tempo = 100;
            //         break;
            //     case 'c':
            //     case 'C':
            //         tempo = 200;
            //         break;
            //     default:
            //         tempo = -1;
            //         break;
            // }

            // if(tempo<0){
            //     Console.WriteLine("Transporte indisponível");
            // }else{
            //     Console.WriteLine("tempo estimado: {0} minutos", tempo);
            // }
        }
    }
}