using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace codeCampTutorial
{
    internal class WordBackwards
    {
        public static void Run()
        {
            Console.WriteLine("Enter a word");
            var word = Console.ReadLine();

            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    Console.Write(word[i]);
                    Thread.Sleep(250);

                }

                Console.WriteLine();
                for (int i = word.Length - 1; i >= 0; i--)
                {

                    Console.Write(word[i]);
                    Thread.Sleep(250);
                }

            } else
            {
                Console.WriteLine("You didn't enter a word");
            }

            
        }

    }

}
