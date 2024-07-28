using System;
//GO TO
namespace Teste12
{
    class Teste12
    {
        static void Main(string[] args)
        {
            int tempo,escolha;

            inicio: //label
            Console.Clear(); //limpa o console

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

            Console.WriteLine("Deseja escolher outro transporte? [1]Sim [2]Nao");
            escolha = int.Parse(Console.ReadLine());

            if(escolha == 1){
                goto inicio; //vai para o label
            }else{
                Console.Clear();
                Console.WriteLine("Fim do programa");
            }
        }
    }
}