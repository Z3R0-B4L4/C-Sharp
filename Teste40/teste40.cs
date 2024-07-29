using System;
//STRUCT
//armazena mais de um tipo de dados
//não pode ser herdado nem usado como base para outras classes
//pode ter construtores
namespace Teste40
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
    }

    class Teste40
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Chevrolet","Celta","Prata");
            Console.WriteLine("Marca: {0}\nModelo: {1}\nCor: {2}",c1.marca,c1.modelo,c1.cor);

        }
    }
}