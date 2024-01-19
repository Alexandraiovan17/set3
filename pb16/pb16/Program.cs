using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți dimensiunea vectorului: ");
            int n = int.Parse (Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("Introduceți elementele vectorului:");

            for (int i = 0; i < n; i++)
            {
              
                vector[i] = int.Parse(Console.ReadLine());
            }

            int cmmd = CalculateCMMD(vector);

            Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este: {cmmd}");
        }

        static int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int CalculateCMMD(int[] vector)
        {
            if (vector.Length == 0)
            {
                Console.WriteLine("Vectorul este gol. Nu există un CMMD definit.");
                return -1; 
            }

            int cmmd = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {
                cmmd = CalculateGCD(cmmd, vector[i]);

                if (cmmd == 1) 
                    break;
            }

            return cmmd;
        }
    }
    }

