using System;
//CADEIA DE HERANÇA
namespace Teste31
{

    class Veiculo{ //classe Base
        public int velMax;
        private int rodas;
        private bool ligado;

        public Veiculo(int rodas){
            this.rodas = rodas;
        }

        public void ligar(){
            ligado = true;
        }

        public void desligar(){
            ligado=false;
        }

        public string getLigado(){
            return ligado ? "sim" : "nao"; //? = ternario, se ligado retornar sim, se nao retornar nao
        }
        public int getRodas(){
            return rodas;
        }

        public void setRodas(int rodas){
            if(rodas < 0){
                this.rodas = 0;
            }else if(rodas > 8){
                this.rodas = 8;
            }else{
                this.rodas = rodas;
            }
        }
    }

    class Carro : Veiculo{ //classe derivada, herda de Veiculo os atributos e metodos
        public string nome;
        public string cor;
        public Carro(string nome, string cor):base(4){
            ligar();
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }
    }

    class CarroCombate:Carro{ //classe derivada, herda de Carro os atributos e metodos
        public int municao;
        public CarroCombate():base("Kuruma","Preto"){
            municao = 100;
            setRodas(3);
        }
    }

    class Teste31
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Celta","Prata");
            CarroCombate cc1 = new CarroCombate();

            Console.WriteLine("Nome: {0}\nCor: {1}\nRodas: {2}\nVelocidade Maxima: {3}\nLigado: {4}",c1.nome,c1.cor,c1.getRodas(),c1.velMax,c1.getLigado());
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Nome: {0}\nCor: {1}\nRodas: {2}\nVelocidade Maxima: {3}\nLigado: {4}\nMunicao: {5}",cc1.nome,cc1.cor,c1.getRodas(),cc1.velMax,cc1.getLigado(),cc1.municao);
        }
    }
}