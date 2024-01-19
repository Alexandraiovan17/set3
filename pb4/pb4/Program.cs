using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introduceti lungimea vectorului ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("introduceti elementele vectorului ");

            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            DeterminaMinMaxSiAparitii(vector);
        }

        static void DeterminaMinMaxSiAparitii(int[] vector)
        {
            if (vector.Length == 0)
            {
                Console.WriteLine("Vectorul este gol");
                return;
            }

            int min = vector[0];
            int max = vector[0];
            int numarAparitiiMin = 1;
            int numarAparitiiMax = 1;

            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] < min)
                {
                    min = vector[i];
                    numarAparitiiMin = 1;
                }
                else if (vector[i] == min)
                {
                    numarAparitiiMin++;
                }

                if (vector[i] > max)
                {
                    max = vector[i];
                    numarAparitiiMax = 1;
                }
                else if (vector[i] == max)
                {
                    numarAparitiiMax++;
                }
            }

            Console.WriteLine($"Cea mai mica valoare din vector este {min}, aparand de {numarAparitiiMin} ori");
            Console.WriteLine($"Cea mai mare valoare din vector este {max}, aparand de {numarAparitiiMax} ori");
        }
    }
}