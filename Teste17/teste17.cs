using System;
//LOOP DO WHILE
namespace Teste17
{
    class Teste17
    {
        static void Main(string[] args)
        {
            string senha = "1234";
            string senhaDigitada;
            int tentativas = 0;

            do{ //o do while diferente do while executa o comando pelo menos uma vez e depois verifica a condicional
                Console.Clear();
                Console.WriteLine("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
                tentativas++;
            }
            while(senha != senhaDigitada);{
                
            }

            Console.WriteLine("Acesso permitido, Tentativas: {0}", tentativas);
        }
    }
}