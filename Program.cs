using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов массива: ");
            int i;
            int n = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Введите элемент x[{0}]: ", i);
                intArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Укажите, в какую сторону должен происходить сдвиг массива. Если вправо - введите 0, влево - 1:");
            int np = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество шагов, на которые должен быть сдвинут массив:");
            int k = int.Parse(Console.ReadLine());
            if (np == 0)
            {
                for (i = n - k; i < n; i++)
                {
                    Console.Write("{0} ", intArray[i]);
                }
                for (i = 0; i < n - k; i++)
                {
                    Console.Write("{0} ", intArray[i]);
                }
                Console.WriteLine("");
            }
            else
            {

                for (i = 0 + k; i < n; i++)
                {
                    Console.Write("{0} ", intArray[i]);
                }
                for (i = 0; i < k; i++)
                {
                    Console.Write("{0} ", intArray[i]);
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
