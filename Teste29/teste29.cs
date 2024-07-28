using System;
//PUBLIC / PRIVATE
namespace Teste29
{

    class Jogador{

        private int vida; //private precisa de getters e setters para ser acessado e alterado
        private string nome;

        public Jogador(string n){
            vida = 100;
            this.nome = n;
        }

        public int getVida(){
            return this.vida;
        }

        public void setVida(int v){
            if(v<0){
                if(vida+v < 0){
                    vida = 0;
                }else{
                    vida+=v;
                }
            }else if(v>0){
                if(vida+v > 100){
                    vida = 100;
                }else{
                    vida+=v;
                }
            }

        }

        public string getNome(){
            return this.nome;
        }

    }

    class Teste29
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador("Eduardo");

            j1.setVida(-30);
            Console.WriteLine("Nome: {0}\nHP: {1}",j1.getNome(),j1.getVida());
        }
    }
}