using System;
//CONSTRUTORES E DESTRUTORES

namespace Teste25
{

    public class Jogador{

        public int vida;
        public bool vivo;
        public string nome;
        public Jogador(string n){//construtor
            vida=100;
            vivo=true;
            nome=n;
        }

        ~Jogador(){//destrutor, destrutor se inicia com "~"
            Console.WriteLine("Jogador {0} foi deletado",nome);
        }
    }


    class Teste25 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o nome: ");
            string nome = Console.ReadLine();
            Jogador j1 = new Jogador(nome);
            //Jogador j1 = new Jogador("Eduardo");
            
            j1.vida = 80;
            Console.WriteLine("\nNome do Jogador: {0}\nHP: {1}",j1.nome,j1.vida);
        }

    }
}