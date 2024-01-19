using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți lungimea vectorului: ");
            int lungime = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceți elementele vectorului (separate prin spațiu): ");
            int[] vector = CitesteVector(lungime);

            MergeSort(vector, 0, lungime - 1);

            Console.WriteLine("Vectorul sortat:");
            AfiseazaVector(vector);
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

        static void MergeSort(int[] vector, int stanga, int dreapta)
        {
            if (stanga < dreapta)
            {
                int mijloc = (stanga + dreapta) / 2;

                MergeSort(vector, stanga, mijloc);
                MergeSort(vector, mijloc + 1, dreapta);

                Interclaseaza(vector, stanga, mijloc, dreapta);
            }
        }

        static void Interclaseaza(int[] vector, int stanga, int mijloc, int dreapta)
        {
            int lungimeStanga = mijloc - stanga + 1;
            int lungimeDreapta = dreapta - mijloc;

            int[] stangaTemp = new int[lungimeStanga];
            int[] dreaptaTemp = new int[lungimeDreapta];

            for (int i = 0; i < lungimeStanga; i++)
            {
                stangaTemp[i] = vector[stanga + i];
            }

            for (int j = 0; j < lungimeDreapta; j++)
            {
                dreaptaTemp[j] = vector[mijloc + 1 + j];
            }

            int indexStanga = 0, indexDreapta = 0;
            int indexCurent = stanga;

            while (indexStanga < lungimeStanga && indexDreapta < lungimeDreapta)
            {
                if (stangaTemp[indexStanga] <= dreaptaTemp[indexDreapta])
                {
                    vector[indexCurent] = stangaTemp[indexStanga];
                    indexStanga++;
                }
                else
                {
                    vector[indexCurent] = dreaptaTemp[indexDreapta];
                    indexDreapta++;
                }

                indexCurent++;
            }

            while (indexStanga < lungimeStanga)
            {
                vector[indexCurent] = stangaTemp[indexStanga];
                indexStanga++;
                indexCurent++;
            }

            while (indexDreapta < lungimeDreapta)
            {
                vector[indexCurent] = dreaptaTemp[indexDreapta];
                indexDreapta++;
                indexCurent++;
            }
        }

        static void AfiseazaVector(int[] vector)
        {
            foreach (var element in vector)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
