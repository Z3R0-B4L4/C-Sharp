using System;
using System.Collections.Generic;
//QUEUE
namespace Teste52
{

    class Teste52
    {
        static void Main(string[] args)
        {
            //string[] n = { "Sandro", "Gustavo", "Luana",}
            //Queue<string> nomes = new Queue<string>(n);
            Queue<string> nomes = new Queue<string>(); 
            nomes.Enqueue("Ana Clara");//enqueue insere no final da fila
            nomes.Enqueue("Sofia");
            nomes.Enqueue("Everton");
            nomes.Enqueue("Arthur");

            string n = "Gustavo";
            nomes.Contains(n);
            if(nomes.Contains(n)){
                Console.WriteLine("Nome {0} encontrado",n);
            }else{
                Console.WriteLine("Nome {0} não encontrado",n);
            }

            //nomes.Clear();

            // Console.WriteLine("primeiro Nome: {0}",nomes.Dequeue());//dequeue retira o primeiro elemento da fila
            Console.WriteLine("Primeiro Nome: {0}",nomes.Peek());//pega o primeiro elemento da fila
            foreach(string nome in nomes){//apenas leitura dos elementos
                Console.WriteLine("Nome: {0}",nome);
            }
            // foreach(string n in nomes){//leitura e exclusão dos elementos
            //     n = nomes.Dequeue();
            //     Console.WriteLine("Nome removido: {0}",n);
            // }
            Console.WriteLine("Qtde de elementos: {0}",nomes.Count);

        }
    }
}
