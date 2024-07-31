using System;
using System.Collections.Generic;
//LIST
namespace Teste51
{

    class Teste51
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            List<string> nomes2 = new List<string>();
            string[] nomes3 = new string[7];

            nomes.Add("Clara");
            nomes.Add("Maria");
            nomes.Add("João");
            nomes.Add("Ana");
            nomes.Add("João");

            //nomes2.AddRange(nomes);         
            
            nomes.CopyTo(nomes3,0);
            nomes.Insert(2,"Romeu");
            // nomes.Remove("Maria");
            // nomes.RemoveAt(3);
            // nomes.RemoveAll(nomes);

            
            if (nomes2.Contains("Maria")){
                Console.WriteLine("nome {0} existe", "Maria");
            }else{
                Console.WriteLine("Nome não existe");
            }

            nomes.Sort();
            int pos_nome = nomes.LastIndexOf("João");
            int cap = nomes.Capacity;
            //nomes.Capacity = 15;
            Console.WriteLine("Capacidade: {0}",cap);
            Console.WriteLine("---NOMES 1---");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("Ultimo João está na posição: {0}",pos_nome);

            
            Console.WriteLine("---NOMES 2---");
            foreach (string nome in nomes2)
            {
                Console.WriteLine(nome);
            }

            
            Console.WriteLine("---NOMES 3---");
            foreach (string nome in nomes3)
            {
                Console.WriteLine(nome);
            }

            string n = "Ana";
            int pos = nomes.IndexOf(n);
            Console.WriteLine("{0} está na posição: {1}",n,pos);
        }
    }
}
