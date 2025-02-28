using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Class1
    {
        class ArraySwapper
        {
            private double[] array;
            private int swapCount;

            public ArraySwapper()
            {
                array = new double[14];
                swapCount = 0;
            }

            public void InputArray()
            {
                Console.WriteLine("Введите 14 элементов массива:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    array[i] = double.Parse(Console.ReadLine());
                }
            }

            public void SwapHalves()
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    double temp = array[i];
                    array[i] = array[i + array.Length / 2];
                    array[i + array.Length / 2] = temp;
                    swapCount++;
                }
            }

            public void PrintResults()
            {
                Console.WriteLine("\nМассив после перестановки:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }

                Console.WriteLine($"\n\nКоличество перестановок: {swapCount}");
            }
        }

        class Program
        {
            static void Main()
            {
                ArraySwapper swapper = new ArraySwapper();

                swapper.InputArray();
                swapper.SwapHalves();
                swapper.PrintResults();
            }
        }
    }
}
