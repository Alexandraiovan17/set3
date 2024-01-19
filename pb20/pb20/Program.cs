using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți primul șirag de mărgele (s1): ");
            string s1 = Console.ReadLine();

            Console.Write("Introduceți al doilea șirag de mărgele (s2): ");
            string s2 = Console.ReadLine();

            int numarSuprapuneri = NumarSuprapuneri(s1, s2);

            Console.WriteLine($"Numărul de suprapuneri este: {numarSuprapuneri}");
        }

        static int NumarSuprapuneri(string s1, string s2)
        {
            int numarSuprapuneri = 0;
            int lungimeS1 = s1.Length;
            int lungimeS2 = s2.Length;

            for (int i = 0; i < lungimeS1; i++)
            {
                for (int j = 0; j < lungimeS2; j++)
                {
                    int suprapunere = VerificaSuprapunere(s1, s2, i, j);
                    numarSuprapuneri += suprapunere;
                }
            }

            return numarSuprapuneri;
        }

        static int VerificaSuprapunere(string s1, string s2, int startIndexS1, int startIndexS2)
        {
            int numarSuprapuneri = 0;
            int lungimeS1 = s1.Length;
            int lungimeS2 = s2.Length;

            for (int i = 0; i < Math.Min(lungimeS1 - startIndexS1, lungimeS2 - startIndexS2); i++)
            {
                if (s1[startIndexS1 + i] == s2[startIndexS2 + i])
                {
                    numarSuprapuneri++;
                }
                else
                {
                    break; 
                }
            }

            return numarSuprapuneri;
        }
    }
}
