using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_22
{
    class Program
    {
        static void Sum (int [] array)
        {
            int S = 0;
            for (int i = 0; i < array.Length; i++)
            {
                S += array[i];
            }
            Console.WriteLine($"Сумма чисел массива = {S}");
        }
        static void Max (Task task, Object a)
        {
            int[] array = (int[])a;
            int M = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array [i] > M)
                {
                    M = array[i];
                }
            }
            Console.WriteLine($"Максимальное число в массиве - {M}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество ячеек массива");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[l];
            Random random = new Random();
            for (int i = 0; i < l; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write(array [i] + " ");
            }
            Console.WriteLine();
            Task task1 = Task.Run(() => Sum(array));

            Action<Task, object> actionTask = new Action<Task, object>(Max);
            Task task2 = task1.ContinueWith(actionTask, array);
            Console.ReadKey();
        }
    }
}
