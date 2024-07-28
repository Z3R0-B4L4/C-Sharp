using System;
//CLASSES E MÉTODOS ABSTRATOS
//se uma classe abstrata possuir métodos abstratos, as classes derivadas são obrigadas a implementar todos os métodos abstratos
//objetos de uma classe abstrata não podem ser instanciados
namespace Teste35
{

    abstract class Veiculo{//classe base abstrata
        protected int velMax;
        protected int velAtual;
        protected bool ligado;

        public Veiculo(){
            velAtual = 0;
            ligado = false;
        }
        
        public void setLigado(bool ligado){//metodo não abstrato, deve ter implementação
            this.ligado = ligado;
        }

        abstract public void aceleracao(int mult);//metodo abstrato, nao tem implementação

        public int getVelAtual(){
            return velAtual;
        }
    }

    class Carro : Veiculo{

        public Carro(){
            velMax = 120;
        }
        override public void aceleracao(int mult){
            velAtual += 10*mult;
        }
    }

    class Teste35
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            c1.aceleracao(2);
            Console.WriteLine(c1.getVelAtual());
        }
    }
}