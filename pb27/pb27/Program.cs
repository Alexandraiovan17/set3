using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți lungimea vectorului: ");
            int lungime = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceți elementele vectorului (separate prin spațiu): ");
            int[] vector = CitesteVector(lungime);

            Console.Write("Introduceți indexul dorit: ");
            int index = Convert.ToInt32(Console.ReadLine());

            int valoareDupaSortare = ValoareDupaSortare(vector, index);
            Console.WriteLine($"Valoarea de pe poziția {index} după sortare este: {valoareDupaSortare}");
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

        static int ValoareDupaSortare(int[] vector, int index)
        {
           
            int[] vectorSortat = (int[])vector.Clone();
            Array.Sort(vectorSortat);

            
            return vectorSortat[index];
        }
    }
}
