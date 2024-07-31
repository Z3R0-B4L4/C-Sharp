using System;
using System.Collections.Generic;
//LINKED LIST
namespace Teste50
{

    class Teste50
    {
        static void Main(string[] args)
        {
            LinkedList<string> nomes = new LinkedList<string>();

            nomes.AddFirst("Eduardo");
            nomes.AddFirst("Maria");
            nomes.AddFirst("João");
            nomes.AddFirst("Ana");
            nomes.AddFirst("Carlos");

            nomes.AddLast("Joaquim");

            LinkedListNode<string> node = nomes.Find("João").Next;
            nomes.AddAfter(node, "Romeu");
            nomes.AddBefore(node, "Antonio");

            // nomes.RemoveFirst();
            // nomes.RemoveLast();
            // nomes.Remove("Maria");
            // nomes.clear();

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            
        }
    }
}
