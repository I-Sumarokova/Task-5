using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            int S = 0;

            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }

            int max = array[0];
            foreach (int a in array)
            {
                if (a > max)
                max = a;
            }

            int min = array[0];
            foreach (int a in array)
            {
                if (a < min)
                min = a;
            }

            S = max + min;

            Console.WriteLine();
            Console.WriteLine("max элемент массива = {0}",max);
            Console.WriteLine("min элемент массива = {0}",min);
            Console.WriteLine("Сумма max и min элементов массива = {0}", S);
            Console.ReadKey();
        }
    }
}
