using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_3._2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Introduceti lungimea vectorului ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            Console.WriteLine("Introduceti elementele vectorului:");

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Introduceti valoarea cautata (k): ");
            int k = int.Parse(Console.ReadLine());

            int pozitie = GasestePozitie(a, k);

            if (pozitie != -1)
            {
                Console.WriteLine($"Valoarea {k} apare pentru prima data la poziția {pozitie} inn vector");
            }
            else
            {
                Console.WriteLine($"Valoarea {k} nu apare in vector");
            }
        }

        static int GasestePozitie(int[] a, int k)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == k)
                {
                    return i;
                }
            }

            return -1; 
        }
    }
}
