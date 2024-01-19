using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți dimensiunea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("Introduceți elementele vectorului: ");

            for (int i = 0; i < n; i++)
            {
               
                vector[i] =int.Parse(Console.ReadLine());
            }

            InsertionSort(vector);

            Console.WriteLine("Vectorul sortat:");

            foreach (var element in vector)
            {
                Console.Write($"{element} ");
            }
        }

        static void InsertionSort(int[] a)
        {
            int n = a.Length;

            for (int i = 1; i < n; i++)
            {
                int key = a[i];
                int j = i - 1;

                
                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j--;
                }

               
                a[j + 1] = key;
            }
        }
    }
}
