using System;
//MÉTODOS QUE RETORNAM OBJETOS
namespace Teste42
{

    class Galinha{
        private string nomeGalinha;
        private int numOvo;
        public Galinha(string nomeGalinha){
            this.nomeGalinha = nomeGalinha;
            this.numOvo = 0;
        }

        public Ovo botar(){
            numOvo++;
            return new Ovo(numOvo,nomeGalinha);
        }


    }

    class Ovo{
        private int numOvo;
        private string minhaGalinha;
        public Ovo(int numOvo, string minhaGalinha){
            this.numOvo = numOvo;
            this.minhaGalinha = minhaGalinha;
            Console.WriteLine("Ovo criado: {0} - {1}",numOvo,minhaGalinha);
        }
    }

    class Teste42
    {
        static void Main(string[] args)
        {
            Galinha g1 = new Galinha("Galinha1");
            Galinha g2 = new Galinha("GalinhaRandom");
            Galinha g3 = new Galinha("GalinhaAutomatron");

            g1.botar();
            g1.botar();
            g2.botar();
            g3.botar();
        }
    }
}