using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace codeCampTutorial
{
    internal class Area
    {
        
        public static void Run()
        {
            Console.Write("Enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            int area = calculateArea(width, height);
            Console.WriteLine("The area is: " + area);
        }

        
        public static int calculateArea(int width, int height)
        {
            int area = (width * height) / 2;
            return area;
        }
    }
}




