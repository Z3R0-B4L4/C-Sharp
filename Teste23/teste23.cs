using System;
//ARGUMENTO PARAMS
namespace Teste23
{

    class Teste23
    {
        static void Main(string[] args)
        {
            soma(4,5,10);
        }

        static void soma(params int[]n){ //params = indica que o método pode receber quantos parâmetros quiser
            int res = 0;
            //params requer um cuidado para verificar quantos valores foram informados
            if (n.Length < 1){
                Console.WriteLine("Nenhum valor foi informado");
            }else if(n.Length < 2){
                Console.WriteLine("Valores insuficientes para soma, valor informado: {0}",n[0]);
            }else{
                for(int i = 0; i < n.Length; i++){
                    res += n[i];
                }
                Console.WriteLine("A soma dos valores é: {0} ",res);
            }
            
        }
    }
}