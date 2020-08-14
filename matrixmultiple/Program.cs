using System;
using System.Globalization;
using System.Diagnostics;
using System.Xml.Schema;
using System.Threading;

namespace matrixmultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int M=1500;
            int N = M;

            Random rnd = new Random();
            Stopwatch sw = new Stopwatch();

            int[,] A = new int[N,M];
            int[,] B = new int[N, M];
            int[,] C = new int[N, M];

            for(int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next();
                    B[i, j] = rnd.Next();
                }
            }
            Console.WriteLine("Start!");
            sw.Start();
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    int total = 0;
                    for(int k = 0; k < N; k++) { 
                        total +=  A[i,k] * B[k,j]; 
                    }
                    C[i, j] = total;
                }
            }
            sw.Stop();
            Console.WriteLine("Elapsed={0}", sw.Elapsed);
            Console.WriteLine("Done!");

        }
    }
}
