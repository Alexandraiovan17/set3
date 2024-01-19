using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Console.WriteLine("Introduceti elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
              
                vector[i] = int.Parse(Console.ReadLine());
            }
            InverseazaVector(vector);
            Console.WriteLine("Vectorul dupa inversare:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"{vector[i]} ");
            }
            Console.ReadLine();
        }
        static void InverseazaVector(int[] a)
        {
            int lungime = a.Length;
            for (int i = 0; i < lungime / 2; i++)
            {
                int temp = a[i];
                a[i] = a[lungime - 1 - i];
                a[lungime - 1 - i] = temp;
            }
        }
    }
}
