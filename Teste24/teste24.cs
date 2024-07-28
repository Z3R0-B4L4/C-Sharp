using System;
//CLASSES E OBJETOS

namespace Teste24
{
//[MODIFICADOR DE ACESSO] class [NOME DA CLASSE]
//public: classe publica, sem restrição de visualização
//abstract: classe base para outras classes, os objetos desta classe não podem ser instanciada
//sealed: classe sealed, não pode ser herdada
//static: classe static, os objetos desta classe não podem ser instanciados e seus membros devem ser static

    public class Jogador{
        //[ESPECIFICADOR DE ACESSO] tipo [NOME DA VARIAVEL/OBJETO]
        public int vida = 100;
        public bool vivo = true;
    }


    class Teste24 //classe sem modificador torna a classe automaticamente publica
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador();//instanciação da classe
            
            j1.vida = 80;
            Console.WriteLine("HP: {0}",j1.vida);
        }

        //[ESPECIFICADOR DE ACESSO] tipo [NOME DA VARIAVEL/OBJETO]
        //public: sem restrição de acesso
        //private: só pode ser acessado pela própria classe
        //protected: acesso apenas dentro da classe e classes derivadas
        //abstract: os métodos não tem implementação somente os cabecalhos
        //sealed: o método não pode ser redefinido
        //virtual: o método pode ser redefinido em uma classe derivada
        //static: o método pode ser chamado sem a instanciação de um objeto
        static void exemplo(){
            
        }
    }
}