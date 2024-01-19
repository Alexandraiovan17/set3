using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente ale vectorului ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
               
                a[i] = int.Parse(Console.ReadLine());
            }
            int pozMin = 0, pozMax = 0;
            if (a[0] < a[1])
            {
                pozMin = 0;
                pozMax = 1;
            }
            else
            {
                pozMin = 1;
                pozMax = 0;
            }
            for (int i = 2; i < n - 1; i += 2)
            {
                if (a[i] < a[i + 1])
                {
                    if (a[i] < a[pozMin])
                    {
                        pozMin = i;
                    }

                    if (a[i + 1] > a[pozMax])
                    {
                        pozMax = i + 1;
                    }
                }
                else
                {
                    if (a[i + 1] < a[pozMin])
                    {
                        pozMin = i + 1;
                    }

                    if (a[i] > a[pozMax])
                    {
                        pozMax = i;
                    }
                }
            }
            if (n % 2 != 0)
            {
                if (a[n - 1] < a[pozMin])
                {
                    pozMin = n - 1;
                }
                else if (a[n - 1] > a[pozMax])
                {
                    pozMax = n - 1;
                }
            }
            Console.WriteLine($"Pozitia celui mai mic element {pozMin + 1}");
            Console.WriteLine($"Pozitia celui mai mare element {pozMax + 1}");
            Console.ReadLine();
        }
    }
}