using System;
//SOBRECARGA DE CONSTRUTORES
namespace Teste26
{

    public class Jogador{

        public int vida;
        public bool vivo;
        public string nome;

        public Jogador(){
            vida = 100;
            vivo = true;
            nome = "Jogador";
        }
        public Jogador(string n){
            vida=100;
            vivo=true;
            nome=n;
        }

        public Jogador(string n, int v){
            vida=v;
            vivo=true;
            nome=n;
        }
        public Jogador(string n, int v, bool hp){
            vida=v;
            vivo=hp;
            nome=n;
        }

        public void info(){
            Console.WriteLine("\nNome: {0}\nHP: {1}\nStatus: {2}",nome,vida,vivo);
        }


    }


    class Teste26 
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador("Eduardo");
            Jogador j3 = new Jogador("Zero",57);
            Jogador j4 = new Jogador("Odin",0,false);
            
            j1.info();
            j2.info();
            j3.info();
            j4.info();
            
        }

    }
}