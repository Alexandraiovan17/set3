using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți lungimea primului vector (v1): ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceți elementele primului vector (0 sau 1, separate prin spațiu): ");
            int[] v1 = CitesteVector(n1);

            Console.Write("Introduceți lungimea celui de-al doilea vector (v2): ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceți elementele celui de-al doilea vector (0 sau 1, separate prin spațiu): ");
            int[] v2 = CitesteVector(n2);

            int[] intersectie = Intersectie(v1, v2);
            AfiseazaRezultat("Intersectia (v1 ∩ v2)", intersectie);

            int[] reuniune = Reuniune(v1, v2);
            AfiseazaRezultat("Reuniunea (v1 ∪ v2)", reuniune);

            int[] diferentaV1MinusV2 = Diferenta(v1, v2);
            AfiseazaRezultat("Diferenta (v1 - v2)", diferentaV1MinusV2);

            int[] diferentaV2MinusV1 = Diferenta(v2, v1);
            AfiseazaRezultat("Diferenta (v2 - v1)", diferentaV2MinusV1);
        }

        static int[] CitesteVector(int lungime)
        {
            int[] vector = new int[lungime];
            string[] elemente = Console.ReadLine().Split(' ');

            for (int i = 0; i < lungime; i++)
            {
                vector[i] = Convert.ToInt32(elemente[i]);
            }

            return vector;
        }

        static int[] Intersectie(int[] v1, int[] v2)
        {
            int lungimeIntersectie = Math.Min(v1.Length, v2.Length);
            int[] intersectie = new int[lungimeIntersectie];

            for (int i = 0; i < lungimeIntersectie; i++)
            {
                intersectie[i] = v1[i] & v2[i];
            }

            return intersectie;
        }

        static int[] Reuniune(int[] v1, int[] v2)
        {
            int lungimeReuniune = Math.Max(v1.Length, v2.Length);
            int[] reuniune = new int[lungimeReuniune];

            for (int i = 0; i < v1.Length; i++)
            {
                reuniune[i] = v1[i];
            }

            for (int i = 0; i < v2.Length; i++)
            {
                reuniune[i] |= v2[i];
            }

            return reuniune;
        }

        static int[] Diferenta(int[] v1, int[] v2)
        {
            int lungimeDiferenta = Math.Max(v1.Length, v2.Length);
            int[] diferenta = new int[lungimeDiferenta];

            for (int i = 0; i < v1.Length; i++)
            {
                diferenta[i] = v1[i] & ~v2[i];
            }

            return diferenta;
        }

        static void AfiseazaRezultat(string operatie, int[] rezultat)
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
