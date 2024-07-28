using System;
//INTERFACES
namespace Teste39
{

    public interface Veiculo{
        void ligar();
        void desligar();
        void info();
    }

    public interface Combate{
        void disparar();
    }

    class Carro:Veiculo,Combate{//A classe que usar a interface, deve implementar todos os seus membros, mais de uma interface pode ser usada por uma classe

        public bool ligado;
        private int municao;
        public Carro(){
            setMunicao(50);
        }

        public void setMunicao(int qtde){
            this.municao = qtde;
        }

        public void ligar(){
            this.ligado = true;
        }

        public void desligar(){
            this.ligado = false;
        }

        public void info(){

        }

        public void disparar(){
            
        }
    }

    class Teste39
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
        }
    }
}