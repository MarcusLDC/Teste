using System;
using System.Collections.Generic;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mudança");
            const int TAM = 2;
            int[,] matriz = new int[TAM,TAM];
            int negativos = 0;
            for(int i = 0; i < TAM; i++)
            {
                for(int j = 0; j < TAM; j++)
                {
                    matriz[i,j] = int.Parse(Console.ReadLine());
                    if (matriz[i,j] <= 0)
                        negativos += 1;
                }
            }
            Console.WriteLine("\nExistem " + negativos + " números negativos na matriz");
            Console.Write("\nA diagonal da matriz é composta pelos números : ");
            for(int i = 0; i < TAM; i++)
            {
                Console.Write("["+ matriz[i,i]+"]");
            }
        }
    }
}