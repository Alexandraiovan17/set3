using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți dimensiunea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            Console.WriteLine("Introduceți elementele vectorului:");

            for (int i = 0; i < n; i++)
            {
                
                a[i] = int.Parse(Console.ReadLine());
            }

            RearrangeVector(a);

            Console.WriteLine("Vectorul rearanjat:");

            foreach (var element in a)
            {
                Console.Write($"{element} ");
            }
        }

        static void RearrangeVector(int[] vector)
        {
            int n = vector.Length;
            int zeroIndex = 0;

            for (int i = 0; i < n; i++)
            {
                if (vector[i] != 0)
                {

                    int temp = vector[i];
                    vector[i] = vector[zeroIndex];
                    vector[zeroIndex] = temp;

                    zeroIndex++;
                }
            }
        }
    }
}

