using System;
//ARRAYS DE STRUCTS
namespace Teste41
{

    struct Carro
    {
        public string marca;
        public string modelo;
        public string cor;

        public Carro(string marca,string modelo, string cor){
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
        }

        public void info(){
            Console.WriteLine("Marca: {0}\nModelo: {1}\nCor: {2}\n",this.marca,this.modelo,this.cor);
        }
    }

    class Teste41
    {
        static void Main(string[] args)
        {
            Carro[] carros = new Carro[5];

            carros[0] = new Carro("Chevrolet","Celta","Prata");
            carros[1] = new Carro("Fiat","Palio","Branco");
            carros[2] = new Carro("Volkswagen","Gol","Vermelho");
            carros[3] = new Carro("Ford","Fiesta","Azul");
            carros[4] = new Carro("Toyota","Corolla","Preto");

            // foreach(Carro c in carros){
            //     c.info();
            // }

            for(int i=0;i<carros.Length;i++){
                carros[i].info();
            }

        }
    }
}