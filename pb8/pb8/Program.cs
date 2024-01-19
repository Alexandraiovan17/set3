using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Introduceti elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
               
                a[i] = int.Parse(Console.ReadLine());
            }
            RotireSpreStanga(a);
            Console.WriteLine("Vectorul dupa rotirea spre stanga:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.ReadLine();
        }
        static void RotireSpreStanga(int[] vector)
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

