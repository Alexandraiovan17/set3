using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu un numar natural n ");
            int n = int.Parse(Console.ReadLine());
            AfiseazaNumerePrime(n);
        }

        static void AfiseazaNumerePrime(int n)
        {
            if (n < 2)
            {
                Console.WriteLine("Nu exista numere prime mai mici sau egale cu 2");
                return;
            }

            bool[] Prim = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
               Prim[i] = true;
            }

            for (int i = 2; i * i <= n; i++)
            {
                if (Prim[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        Prim[j] = false;
                    }
                }
            }

            Console.WriteLine($"Numere prime mai mici sau egale cu {n}:");
            for (int i = 2; i <= n; i++)
            {
                if (Prim[i])
                {
                    Console.Write(i + " ");
                    Console.ReadLine();
                }
            }
        }
    }
}
