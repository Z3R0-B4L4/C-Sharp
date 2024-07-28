using System;
//CLASSES STATIC
namespace Teste27
{

    static public class Jogador{ //classe static não pode ter construtor e seus métodos e membros precisão ser static

        static public int vida;
        static public bool vivo;
        static public string nome;


        static public void iniciar(string n){
            vida=100;
            vivo=true;
            nome=n;
        }

        static public void info(){
            Console.WriteLine("\nNome: {0}\nHP: {1}\nStatus: {2}",nome,vida,vivo);
        }


    }


    class Inimigo{
        static public bool alerta;
        public string nome;
        public Inimigo(string n){
            alerta=false;
            nome=n;
        }

        public void info(){
            Console.WriteLine("\nNome: {0}\nAlerta: {1}",nome,alerta);
            Console.WriteLine("");
        }
    }

    class Teste27 
    {
        static void Main(string[] args)
        {

            //Jogador j1 = new Jogador(); por causa da classe Jogador ser static, este comando está errado, pois não pode ser instanciado
            Jogador.iniciar("Eduardo");
            Jogador.info();
            
            Inimigo i1 = new Inimigo("Dracula");
            Inimigo i2 = new Inimigo("Demon");
            Inimigo i3 = new Inimigo("Cerberus");

            i1.info();
            Inimigo.alerta = true;
            i2.info();
            i3.info();
        }

    }
}