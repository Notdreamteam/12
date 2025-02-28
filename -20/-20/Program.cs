using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
       
            class MonotonicDecreaseFinder
        {
            private int[] array;

            // Конструктор для инициализации массива
            public MonotonicDecreaseFinder(int[] inputArray)
            {
                array = inputArray;
            }

            // Метод для поиска индексов монотонно убывающих последовательностей
            public List<List<int>> FindDecreasingSequences()
            {
                List<List<int>> sequences = new List<List<int>>();
                List<int> currentSequence = new List<int>();

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        if (currentSequence.Count == 0)
                        {
                            currentSequence.Add(i);
                        }
                        currentSequence.Add(i + 1);
                    }
                    else
                    {
                        if (currentSequence.Count > 1)
                        {
                            sequences.Add(new List<int>(currentSequence));
                        }
                        currentSequence.Clear();
                    }
                }

                // Проверка последней последовательности
                if (currentSequence.Count > 1)
                {
                    sequences.Add(new List<int>(currentSequence));
                }

                return sequences;
            }
        }

        class Program
        {
            static void Main()
            {
                int[] array = { 5, 4, 3, 7, 6, 5, 4, 8, 7, 6, 5 }; // Пример массива

                // Создаем объект класса MonotonicDecreaseFinder
                MonotonicDecreaseFinder finder = new MonotonicDecreaseFinder(array);

                // Вызываем метод для поиска монотонно убывающих последовательностей
                var sequences = finder.FindDecreasingSequences();

                // Выводим результат
                Console.WriteLine("Индексы монотонно убывающих последовательностей:");
                foreach (var sequence in sequences)
                {
                    Console.WriteLine(string.Join(", ", sequence));
                }
            }
        }
    }
    
}
