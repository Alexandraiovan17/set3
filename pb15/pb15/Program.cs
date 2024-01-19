using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Introduceti elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
               
                a[i] = int.Parse(Console.ReadLine());
            }
            int indexUltimElementUnic = 0;
            for (int i = 0; i < n; i++)
            {
                bool esteDuplicat = false;
                for (int j = 0; j < indexUltimElementUnic; j++)
                {
                    if (a[i] == a[j])
                    {
                        esteDuplicat = true;
                        break;
                    }
                }
                if (!esteDuplicat)
                {
                    a[indexUltimElementUnic] = a[i];
                    indexUltimElementUnic++;
                }
            }
            Console.WriteLine("Vectorul dupa eliminarea duplicatelor ");
            for (int i = 0; i < indexUltimElementUnic; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.ReadLine();
        }
    }
    }

