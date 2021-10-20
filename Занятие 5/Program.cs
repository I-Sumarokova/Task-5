using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int S = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Введите элемент массива ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                S += array[i];
            }
            Console.WriteLine("Вывод массива");

            for (int i = 0; i < 7; i++)
            {
                Console.Write("{0} ",array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое значение = {0}", S/7);
            Console.ReadKey();
        }
    }
}
