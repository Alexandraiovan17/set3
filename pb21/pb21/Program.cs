using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți lungimea primului vector: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceți elementele primului vector (separate prin spațiu): ");
            int[] vector1 = CitesteVector(n1);

            Console.Write("Introduceți lungimea celui de-al doilea vector: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Introduceți elementele celui de-al doilea vector (separate prin spațiu): ");
            int[] vector2 = CitesteVector(n2);

            int rezultatComparare = ComparareLexicografica(vector1, vector2);

            if (rezultatComparare < 0)
            {
                Console.WriteLine("Primul vector este înaintea celui de-al doilea în ordinea lexicografică.");
            }
            else if (rezultatComparare > 0)
            {
                Console.WriteLine("Cel de-al doilea vector este înaintea primului în ordinea lexicografică.");
            }
            else
            {
                Console.WriteLine("Vectorii sunt identici în ordinea lexicografică.");
            }
        }

        static int[] CitesteVector(int lungime)
        {
            int[] vector = new int[lungime];
            string[] elemente = Console.ReadLine().Split(' ');

            for (int i = 0; i < lungime; i++)
            {
                vector[i] = int.Parse(elemente[i]);
            }

            return vector;
        }

        static int ComparareLexicografica(int[] vector1, int[] vector2)
        {
            int minLungime = Math.Min(vector1.Length, vector2.Length);

            for (int i = 0; i < minLungime; i++)
            {
                if (vector1[i] < vector2[i])
                {
                    return -1;
                }
                else if (vector1[i] > vector2[i])
                {
                    return 1;
                }
                
            }
            
            return vector1.Length.CompareTo(vector2.Length);
        }
    }
}
