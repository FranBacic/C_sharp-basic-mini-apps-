using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeCampTutorial
{
    internal class ArraySumOfNumbers
    {
        public static void Run()
        {
            Console.WriteLine("Unesite brojeve odvojene razmakom:");

            
            string input = Console.ReadLine();

            
            int[] array = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            
            Console.WriteLine("Uneseni brojevi:");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            
            if (SumOfNumbers(array, out int result))
            {
                Console.WriteLine("Zbroj brojeva: " + result);
            }
            else
            {
                Console.WriteLine("Niz je prazan");
            }

            
        }

        static bool SumOfNumbers(int[] array, out int result)
        {
            result = 0;

            if (array.Length > 0)
            {
                foreach (var item in array)
                {
                    result += item;
                }
                return true;
            }

            return false;
        }
    }
}
