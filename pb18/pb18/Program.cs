using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți gradul polinomului : ");
            int n = int.Parse(Console.ReadLine());

            double[] coeficienti = new double[n + 1];

            Console.WriteLine("Introduceți coeficienții polinomului de la cel mai mic la cel mai mare grad:");

            for (int i = 0; i <= n; i++)
            {
              
                coeficienti[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Introduceți punctul x la care să calculați valoarea polinomului: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double rezultat = CalculeazaValoareaPolinomului(coeficienti, x);

            Console.WriteLine($"Valoarea polinomului în punctul {x} este: {rezultat}");
        }

        static double CalculeazaValoareaPolinomului(double[] c, double x)
        {
            int n = c.Length;
            double rezultat = 0.0;

            for (int i = 0; i < n; i++)
            {
                rezultat += c[i] * Math.Pow(x, i);
            }

            return rezultat;
        }
    }
}
