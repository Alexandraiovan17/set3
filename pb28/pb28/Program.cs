using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți lungimea vectorului: ");
            int lungime = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceți elementele vectorului (separate prin spațiu): ");
            int[] vector = CitesteVector(lungime);

            Quicksort(vector, 0, lungime - 1);

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

        static void Quicksort(int[] vector, int stanga, int dreapta)
        {
            if (stanga < dreapta)
            {
                int pivot = Partitie(vector, stanga, dreapta);

                Quicksort(vector, stanga, pivot - 1);
                Quicksort(vector, pivot + 1, dreapta);
            }
        }

        static int Partitie(int[] vector, int stanga, int dreapta)
        {
            int pivot = vector[dreapta];
            int i = stanga - 1;

            for (int j = stanga; j < dreapta; j++)
            {
                if (vector[j] < pivot)
                {
                    i++;
                    Schimba(vector, i, j);
                }
            }

            Schimba(vector, i + 1, dreapta);
            return i + 1;
        }

        static void Schimba(int[] vector, int i, int j)
        {
            int temp = vector[i];
            vector[i] = vector[j];
            vector[j] = temp;
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
