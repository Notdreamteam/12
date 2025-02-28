using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        
            class ArrayProcessor
        {
            private int[] array;

            // Конструктор для инициализации массива
            public ArrayProcessor(int[] inputArray)
            {
                array = inputArray;
            }

            // Метод для поиска суммы и последовательности элементов между первым отрицательным и нулевым элементами
            public (int sum, List<int> sequence) FindSumAndSequence()
            {
                int firstNegativeIndex = -1;
                int zeroIndex = -1;
                int sum = 0;
                List<int> sequence = new List<int>();

                // Поиск индексов первого отрицательного и нулевого элементов
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0 && firstNegativeIndex == -1)
                    {
                        firstNegativeIndex = i;
                    }
                    if (array[i] == 0 && zeroIndex == -1)
                    {
                        zeroIndex = i;
                    }
                    if (firstNegativeIndex != -1 && zeroIndex != -1)
                    {
                        break;
                    }
                }

                // Если найдены оба индекса и отрицательный элемент находится перед нулевым
                if (firstNegativeIndex != -1 && zeroIndex != -1 && firstNegativeIndex < zeroIndex)
                {
                    for (int i = firstNegativeIndex + 1; i < zeroIndex; i++)
                    {
                        sum += array[i];
                        sequence.Add(array[i]);
                    }
                }

                return (sum, sequence);
            }
        }

        class Program
        {
            static void Main()
            {
                int[] Z = { 1, 2, -3, 4, 5, 0, 7, 8, -9, 10, 11, 0, 13, 14, 15 }; // Пример массива

                // Создаем объект класса ArrayProcessor
                ArrayProcessor processor = new ArrayProcessor(Z);

                // Вызываем метод для поиска суммы и последовательности
                var result = processor.FindSumAndSequence();

                // Выводим результат
                Console.WriteLine("Сумма элементов: " + result.sum);
                Console.WriteLine("Последовательность элементов: " + string.Join(", ", result.sequence));
            }
        }
    }
 }

