using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți lungimea primului vector (v1): ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceți elementele primului vector (separate prin spațiu): ");
            int[] v1 = CitesteVector(n1);

            Console.Write("Introduceți lungimea celui de-al doilea vector (v2): ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Introduceți elementele celui de-al doilea vector (separate prin spațiu): ");
            int[] v2 = CitesteVector(n2);

            HashSet<int> set1 = new HashSet<int>(v1);
            HashSet<int> set2 = new HashSet<int>(v2);
            HashSet<int> intersectie = new HashSet<int>(set1.Intersect(set2));
            AfiseazaRezultat("Intersectia (v1 ∩ v2)", intersectie);
            HashSet<int> reuniune = new HashSet<int>(set1.Union(set2));
            AfiseazaRezultat("Reuniunea (v1 ∪ v2)", reuniune);
             HashSet<int> diferentaV1MinusV2 = new HashSet<int>(set1.Except(set2));
            AfiseazaRezultat("Diferenta (v1 - v2)", diferentaV1MinusV2);
            HashSet<int> diferentaV2MinusV1 = new HashSet<int>(set2.Except(set1));
            AfiseazaRezultat("Diferenta (v2 - v1)", diferentaV2MinusV1);
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

        static void AfiseazaRezultat(string operatie, HashSet<int> rezultat)
        {
            Console.Write($"{operatie}: ");
            foreach (var element in rezultat)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
