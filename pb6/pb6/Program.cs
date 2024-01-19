using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb6
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
            Console.Write("Introduceti pozitia k pentru stergere (0-primul element): ");
            int k = int.Parse(Console.ReadLine());
            if (k >= 0 && k < n)
            {
                a = StergeElement(a, k);
                Console.WriteLine("Vectorul dupa stergere:");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write($"{a[i]} ");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Pozitia de stergere este invalida.");
                Console.ReadLine();
            }
        }
        static int[] StergeElement(int[] vector, int k)
        {
            for (int i = k; i < vector.Length - 1; i++)
            {
                vector[i] = vector[i + 1];
            }
            Array.Resize(ref vector, vector.Length - 1);
            return vector;
        }
    }
    }

