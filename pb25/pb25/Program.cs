using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți lungimea primului vector (v1): ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceți elementele primului vector (sortate crescător, separate prin spațiu): ");
            int[] v1 = CitesteVector(n1);

            Console.Write("Introduceți lungimea celui de-al doilea vector (v2): ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceți elementele celui de-al doilea vector (sortate crescător, separate prin spațiu): ");
            int[] v2 = CitesteVector(n2);

            int[] rezultat = Interclasare(v1, v2);
            AfiseazaVector("Vectorul interclasat", rezultat);
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

        static int[] Interclasare(int[] v1, int[] v2)
        {
            int lungimeV1 = v1.Length;
            int lungimeV2 = v2.Length;
            int[] rezultat = new int[lungimeV1 + lungimeV2];

            int i = 0, j = 0, k = 0;

            while (i < lungimeV1 && j < lungimeV2)
            {
                if (v1[i] < v2[j])
                {
                    rezultat[k++] = v1[i++];
                }
                else
                {
                    rezultat[k++] = v2[j++];
                }
            }

            while (i < lungimeV1)
            {
                rezultat[k++] = v1[i++];
            }

            while (j < lungimeV2)
            {
                rezultat[k++] = v2[j++];
            }

            return rezultat;
        }

        static void AfiseazaVector(string mesaj, int[] vector)
        {
            Console.Write($"{mesaj}: ");
            foreach (var element in vector)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
