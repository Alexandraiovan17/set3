using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți dimensiunea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("Introduceți elementele vectorului:");

            for (int i = 0; i < n; i++)
            {
              
                vector[i] =int.Parse(Console.ReadLine());
            }

            SelectionSort(vector);

            Console.WriteLine("Vectorul sortat:");

            foreach (var element in vector)
            {
                Console.Write($"{element} ");
            }
        }

        static void SelectionSort(int[] vector)
        {
            int n = vector.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (vector[j] < vector[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = vector[minIndex];
                vector[minIndex] = vector[i];
                vector[i] = temp;
            }
        }
    }
}
