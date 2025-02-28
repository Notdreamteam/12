using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
           
                double[] array = new double[14];
                int swapCount = 0;

                // Ввод массива
                Console.WriteLine("Введите 14 элементов массива:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    array[i] = double.Parse(Console.ReadLine());
                }

                // Поменять местами первую половину массива со второй
                for (int i = 0; i < array.Length / 2; i++)
                {
                    double temp = array[i];
                    array[i] = array[i + array.Length / 2];
                    array[i + array.Length / 2] = temp;
                    swapCount++;
                }

                // Вывод результатов
                Console.WriteLine("\nМассив после перестановки:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }

                Console.WriteLine($"\n\nКоличество перестановок: {swapCount}");
            
        }
    }
}
