using System;
//MEMBROS PROTECTED
namespace Teste32
{

    class Veiculo{
        public int velAtual;
        private int velMax; //private restringe o acesso a própria classe
        protected bool ligado; //protected restringe o acesso a somente classes derivadas

        public Veiculo(int velMax){
            velAtual = 0;
            this.velMax = velMax;
            ligado = false;
        }

        public bool getLigado(){
            return ligado;
        }
        public int getVelMax(){
            return velMax;
        }
    }

    class Carro:Veiculo{
        public string nome;
        public Carro(string nome, int velMax):base(velMax){
            this.nome = nome;
            ligado = true;
        }
    }

    class Teste32
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Celta",120);
            Console.WriteLine("Nome: {0}\nVelocidade Atual: {1}\nVelocidade Maxima: {2}\nLigado: {3}",c1.nome,c1.velAtual,c1.getVelMax(),c1.getLigado());
        }
    }
}