using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int lungime = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[lungime];
            Console.WriteLine("Introduceti elementele vectorului:");
            for (int i = 0; i < lungime; i++)
            {
                
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            int majoritate = GasesteElementMajoritate(vector);
            if (majoritate != -1)
            {
                Console.WriteLine($"Elementul majoritate este: {majoritate}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Nu exista element majoritate.");
                Console.ReadLine();
            }
        }
        static int GasesteElementMajoritate(int[] vector)
        {
            int majoritateCandidat = -1;
            int count = 0;
            foreach (int element in vector)
            {
                if (count == 0)
                {
                    majoritateCandidat = element;
                    count = 1;
                }
                else if (element == majoritateCandidat)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            count = 0;
            foreach (int element in vector)
            {
                if (element == majoritateCandidat)
                {
                    count++;
                }
            }
            return count > vector.Length / 2 ? majoritateCandidat : -1;
        }
    }
    }

