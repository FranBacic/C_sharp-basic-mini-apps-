using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeCampTutorial
{
    internal class TryCatch
    {
        public static void Run()
        {

            bool success = false;

            while (!success)
            {

                try
                {
                    Console.WriteLine("Enter number:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    success = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }

    }

}
