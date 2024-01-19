using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceți vectorul în care se caută (s):");
            int[] s = CitesteVector();

            Console.WriteLine("Introduceți vectorul care se caută (p):");
            int[] p = CitesteVector();

            int numarAparitii = NumarAparitii(s, p);

            Console.WriteLine($"Vectorul p apare în vectorul s de {numarAparitii} ori.");
        }

        static int[] CitesteVector()
        {
            Console.Write("Introduceți dimensiunea vectorului: ");
            int n = int.Parse (Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("Introduceți elementele vectorului:");

            for (int i = 0; i < n; i++)
            {
             
                vector[i] =int.Parse(Console.ReadLine());
            }

            return vector;
        }

        static int NumarAparitii(int[] s, int[] p)
        {
            int numarAparitii = 0;

            if (s.Length < p.Length)
                return 0;

            for (int i = 0; i <= s.Length - p.Length; i++)
            {
                if (VerificaAparitie(s, p, i))
                {
                    numarAparitii++;
                }
            }

            return numarAparitii;
        }

        static bool VerificaAparitie(int[] s, int[] p, int startIndex)
        {
            for (int i = 0; i < p.Length; i++)
            {
                if (s[startIndex + i] != p[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
