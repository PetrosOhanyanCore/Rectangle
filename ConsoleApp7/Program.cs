using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            var val = Console.ReadLine();

            int a = Convert.ToInt32(val);


            var width = CalculateWidth(a);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("_");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static int CalculateWidth(int a)
        {            
            int width = 2;

            while (!IsAbsRectangle(a, width))
            {
                width++;
            }

            return width;
        }

        public static bool IsAbsRectangle(int x, int y)
        {
            if ((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) % 1 == 0))
                return true;
            else
                return false;
        }
    }
}
