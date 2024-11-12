using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeCampTutorial
{
    internal class EvenOddList
    {
        public static void Run()
        {
            List<int> even = new List<int>();

            List<int> odd = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }
            if (even.Count > 0 || odd.Count > 0)
            {
                Console.WriteLine("Parni Brojevi");
                foreach (var item in even)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Neparni Brojevi");

                foreach (var item in odd)
                {
                    Console.Write(item + " ");
                }

            }
            else 
            {
                Console.WriteLine("Lista je prazna");
            }

            Console.ReadLine();
        }
    }

}
