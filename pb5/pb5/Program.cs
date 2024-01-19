using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the vector: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            Console.WriteLine("Enter the elements of the vector:");

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the value to insert (e): ");
            int e = int.Parse(Console.ReadLine());

            Console.Write("Enter the position to insert (k): ");
            int k = int.Parse(Console.ReadLine());

            a = InsertElement(a, e, k);

            Console.WriteLine("Vector after insertion:");

            foreach (var element in a)
            {
                Console.Write($"{element} ");
            }
        }

        static int[] InsertElement(int[] vector, int e, int k)
        {
            if (k < 0 || k > vector.Length)
            {
                Console.WriteLine("Invalid insertion position.");
                return vector;
            }

            Array.Resize(ref vector, vector.Length + 1);

            for (int i = vector.Length - 1; i > k; i--)
            {
                vector[i] = vector[i - 1];
            }

            vector[k] = e;

            return vector;
        }
    }
    }
}
