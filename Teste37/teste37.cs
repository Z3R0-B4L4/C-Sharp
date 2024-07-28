using System;
//GETTERS E SETTERS
namespace Teste37
{

    class Carro{
        private int velMax;
        public int vm{
            get{//get = ler
                return velMax;
            }
            set{//set = escrever
                if(value < 0){
                    velMax = 0;
                }else if(value > 200){
                    velMax=200;
                }else{
                    velMax = value;
                }
            }
        }

        public Carro(){
            vm = 120;
        }

        
    }

    class Teste37
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            c1.vm = 50;
            Console.WriteLine(c1.vm);
        }
    }
}