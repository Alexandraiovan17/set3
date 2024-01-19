using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb9
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
            Console.Write("Introduceti numarul de pozitii pentru rotirea spre stanga (k): ");
            int k = int.Parse(Console.ReadLine());
            RotireSpreStanga(vector, k);
            Console.WriteLine("Vectorul dupa rotirea spre stanga:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"{vector[i]} ");
            }
            Console.ReadLine();
        }
        static void RotireSpreStanga(int[] vector, int k)
        {
            k %= vector.Length; 
            for (int j = 0; j < k; j++)
            {
                int primulElement = vector[0];
                for (int i = 0; i < vector.Length - 1; i++)
                {
                    vector[i] = vector[i + 1];
                }
                vector[vector.Length - 1] = primulElement;
            }
        }
    }
}
