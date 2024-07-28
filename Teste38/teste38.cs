using System;
//INDEXADORES
//permite usar os objetos como vetores/arrays
namespace Teste38
{

    class Carro{
        private int[] velMax = new int[5]{60,120,180,240,300};

        public int this[int i]{
            get{
                return velMax[i];
            }
            set{
                if(value < 0){
                    velMax[i] = 0;
                }else if(value > 200){
                    velMax[i]=200;
                }else{
                    velMax[i] = value;
                }
            }
        }

        public Carro(){
        }

        
    }

    class Teste38
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            c1[4]=50;
            Console.WriteLine(c1[4]);
        }
    }
}