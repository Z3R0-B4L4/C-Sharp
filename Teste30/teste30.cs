using System;
//HERANÇA
namespace Teste30
{

    class Veiculo{ //classe Base
        public int velMax,rodas;
        private bool ligado;

        public void ligar(){
            ligado = true;
        }

        public void desligar(){
            ligado=false;
        }

        public string getLigado(){
            if(ligado){
                return "sim";
            }else{
                return "nao";
            }
        }
    }

    class Carro : Veiculo{ //classe derivada, herda de Veiculo os atributos e metodos
        public string nome, cor;
        public Carro(string nome, string cor){
            desligar();
            rodas = 4;
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }
    }

    class Teste30
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Celta","Prata");
            Console.WriteLine("Nome: {0}\nCor: {1}\nRodas: {2}\nVelocidade Maxima: {3}\nLigado: {4}",c1.nome,c1.cor,c1.rodas,c1.velMax,c1.getLigado());
        }
    }
}