using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți prima cifră a numărului mare: ");
            int[] numar1 = CitesteNumar();

            Console.Write("Introduceți a doua cifră a numărului mare: ");
            int[] numar2 = CitesteNumar();

            int[] suma = Aduna(numar1, numar2);
            AfiseazaNumar("Suma", suma);

            int[] diferenta = Scade(numar1, numar2);
            AfiseazaNumar("Diferența", diferenta);

            int[] produs = Inmulteste(numar1, numar2);
            AfiseazaNumar("Produsul", produs);
        }

        static int[] CitesteNumar()
        {
            string input = Console.ReadLine().Trim();
            return input.Select(c => int.Parse(c.ToString())).ToArray();
        }

        static int[] Aduna(int[] numar1, int[] numar2)
        {
            int n1 = numar1.Length;
            int n2 = numar2.Length;
            int lungimeMaxima = Math.Max(n1, n2) + 1;
            int[] rezultat = new int[lungimeMaxima];

            int carry = 0;

            for (int i = 0; i < lungimeMaxima; i++)
            {
                int digit1 = (i < n1) ? numar1[n1 - 1 - i] : 0;
                int digit2 = (i < n2) ? numar2[n2 - 1 - i] : 0;

                int sumaCifrelor = digit1 + digit2 + carry;
                rezultat[lungimeMaxima - 1 - i] = sumaCifrelor % 10;
                carry = sumaCifrelor / 10;
            }

            return rezultat;
        }

        static int[] Scade(int[] numar1, int[] numar2)
        {
            int n1 = numar1.Length;
            int n2 = numar2.Length;
            int lungimeMaxima = Math.Max(n1, n2);
            int[] rezultat = new int[lungimeMaxima];

            int borrow = 0;

            for (int i = 0; i < lungimeMaxima; i++)
            {
                int digit1 = (i < n1) ? numar1[n1 - 1 - i] : 0;
                int digit2 = (i < n2) ? numar2[n2 - 1 - i] : 0;

                int diferentaCifrelor = digit1 - digit2 - borrow;

                if (diferentaCifrelor < 0)
                {
                    diferentaCifrelor += 10;
                    borrow = 1;
                }
                else
                {
                    borrow = 0;
                }

                rezultat[lungimeMaxima - 1 - i] = diferentaCifrelor;
            }

            return rezultat;
        }

        static int[] Inmulteste(int[] numar1, int[] numar2)
        {
            int n1 = numar1.Length;
            int n2 = numar2.Length;
            int lungimeProdus = n1 + n2;
            int[] rezultat = new int[lungimeProdus];

            for (int i = 0; i < n1; i++)
            {
                int carry = 0;

                for (int j = 0; j < n2; j++)
                {
                    int produsCifre = numar1[n1 - 1 - i] * numar2[n2 - 1 - j] + rezultat[lungimeProdus - 1 - i - j] + carry;

                    rezultat[lungimeProdus - 1 - i - j] = produsCifre % 10;
                    carry = produsCifre / 10;
                }

                rezultat[lungimeProdus - n1 - i - 1] += carry;
            }

            return rezultat;
        }

        static void AfiseazaNumar(string mesaj, int[] numar)
        {
            Console.Write($"{mesaj}: ");
            bool afiseazaZero = false;

            foreach (var cifra in numar)
            {
                if (cifra != 0)
                {
                    afiseazaZero = true;
                }

                if (afiseazaZero)
                {
                    Console.Write(cifra);
                }
            }

            if (!afiseazaZero)
            {
                Console.Write("0");
            }

          
        }
    }
}
