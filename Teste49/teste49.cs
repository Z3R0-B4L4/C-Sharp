using System;
using System.Collections.Generic;
//DICTIONARY
namespace Teste49
{

    class Teste49
    {
        static void Main(string[] args)
        {
            Dictionary <int, string> nomes = new Dictionary<int, string>(); //<'int' (Chave, pode ser de qualquer tipo), 'string' (Valor, pode ser de qualquer tipo)>

            nomes.Add(10, "Eduardo");
            nomes.Add(21, "Maria");
            nomes.Add(32, "João");
            nomes.Add(43, "Ana");
            nomes.Add(54, "Carlos");

            //nomes.Clear();
            nomes.Remove(10);
            nomes[43] = "Joaquim";
            Console.WriteLine("Tamanho do dicionário: {0}",nomes.Count);
            // Console.WriteLine("Digite a chave que deseja buscar: ");
            // int chave = int.Parse(Console.ReadLine());
            // if(nomes.ContainsKey(chave)){
            //     Console.WriteLine("Conteúdo {0} existe",chave);
            // }else{
            //     Console.WriteLine("Conteúdo {0} não existe",chave);
            // }

            Console.WriteLine("Digite o valor que deseja buscar: ");
            string valor = Console.ReadLine();
            if(nomes.ContainsValue(valor)){
                Console.WriteLine("Conteúdo {0} existe",valor);
            }else{
                Console.WriteLine("Conteúdo {0} não existe",valor);
            }
            
            Dictionary<int, string>.KeyCollection chaves = nomes.Keys;

            foreach(int k in chaves){
                Console.WriteLine(k);
            }

            // foreach(KeyValuePair<int, string> s in nomes){
            //     Console.WriteLine(s.Value);
            //     Console.WriteLine(s.Key);
            // }

        }
    }
}
