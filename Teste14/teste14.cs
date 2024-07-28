using System;
//ARRAYS BIDIMENSIONAIS / MATRIZES
namespace Teste14
{
    class Teste14
    {
        static void Main(string[] args)
        {
            int[,] n = new int[3,5]; // Para criar um array bidimensional você deve colocar uma ',' entre as duas chaves '[]', e na hora de inicializar o array, colocar a quantidade de linhas e de colunas separados por uma ',', exemplo: int[,] n = new int[N° de linhas, N° de colunas];
            
            n[0,0]=10;            n[0,1]=20;            n[0,2]=30;            n[0,3]=40;            n[0,4]=50;

            n[1,0]=60;            n[1,1]=70;            n[1,2]=80;            n[1,3]=90;            n[1,4]=100;

            n[2,0]=15;            n[2,1]=25;            n[2,2]=35;            n[2,3]=45;            n[2,4]=55;


            int[,] num= new int[2,2]{{10,20},{30,40}}; //a primeira '{}' representa a matriz, a primeira '{}' serve para os valores da primeira linha e a segunda '{}' para os valores da segunda linha

            Console.WriteLine(num[1,0]);
            
        }
    }
}