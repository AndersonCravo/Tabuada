using System;

namespace TabuadaUsandoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número da tabuada:  ");

            int N;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = N * i;
                Console.WriteLine(N + "x" + i + "=" + resultado);
            }
        }
    }
}
