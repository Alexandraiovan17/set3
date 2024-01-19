using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET3._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti elementele primului vector (ordonat crescator) separate prin spatii:");
            int[] v1 = CitesteVectorDeLaTastatura();
            Console.WriteLine("Introduceti elementele celui de-al doilea vector (ordonat crescator) separate prin spatii:");
            int[] v2 = CitesteVectorDeLaTastatura();
            List<int> intersectie = Intersectie(v1, v2);
            List<int> reuniune = Reuniune(v1, v2);
            List<int> diferentaV1V2 = Diferenta(v1, v2);
            List<int> diferentaV2V1 = Diferenta(v2, v1);
            Console.WriteLine("Intersectie: " + string.Join(", ", intersectie));
            Console.WriteLine("Reuniune: " + string.Join(", ", reuniune));
            Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", diferentaV1V2));
            Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", diferentaV2V1));
            Console.ReadLine();
        }
        static int[] CitesteVectorDeLaTastatura()
        {
            string input = Console.ReadLine();
            string[] elemente = input.Split(' ');
            int[] vector = new int[elemente.Length];
            for (int i = 0; i < elemente.Length; i++)
            {
                vector[i] = int.Parse(elemente[i]);
            }
            return vector;
        }
        static List<int> Intersectie(int[] v1, int[] v2)
        {
            List<int> rezultat = new List<int>();
            int i = 0, j = 0;
            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == v2[j])
                {
                    rezultat.Add(v1[i]);
                    i++;
                    j++;
                }
                else if (v1[i] < v2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            return rezultat;
        }
        static List<int> Reuniune(int[] v1, int[] v2)
        {
            List<int> rezultat = new List<int>();
            int i = 0, j = 0;
            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == v2[j])
                {
                    rezultat.Add(v1[i]);
                    i++;
                    j++;
                }
                else if (v1[i] < v2[j])
                {
                    rezultat.Add(v1[i]);
                    i++;
                }
                else
                {
                    rezultat.Add(v2[j]);
                    j++;
                }
            }
            while (i < v1.Length)
            {
                rezultat.Add(v1[i]);
                i++;
            }
            while (j < v2.Length)
            {
                rezultat.Add(v2[j]);
                j++;
            }
            return rezultat;
        }
        static List<int> Diferenta(int[] v1, int[] v2)
        {
            List<int> rezultat = new List<int>();
            int i = 0, j = 0;
            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == v2[j])
                {
                    i++;
                    j++;
                }
                else if (v1[i] < v2[j])
                {
                    rezultat.Add(v1[i]);
                    i++;
                }
                else
                {
                    j++;
                }
            }
            while (i < v1.Length)
            {
                rezultat.Add(v1[i]);
                i++;
            }
            return rezultat;
        }
    }
}