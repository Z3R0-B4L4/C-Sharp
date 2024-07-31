using System;
//TRY CATCH FINALLY
namespace Teste47
{

    class Teste47
    {
        static void Main(string[] args)
        {
            int a,b,r;

            a=10;
            b=0;

            try
            {
                r=a/b;
                Console.WriteLine("{0}/{1}={2}",a,b,r);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro: {0}",e.Message);
                Console.WriteLine("Stack: {0}",e.StackTrace);
                Console.WriteLine("Source: {0}",e.GetType().Name);
                Console.WriteLine("Source: {0}",e.GetType());
            }
            finally
            {
                Console.WriteLine("Fim");
            }

        }
    }
}