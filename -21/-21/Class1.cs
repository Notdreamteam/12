using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Class1
    {

        class ArrayProcessor
        {
            private int[] array;

            public ArrayProcessor(int[] inputArray)
            {
                array = inputArray;
            }

            public int[] RemoveElementsOccurringMoreThanTwice()
            {
                var countDict = new Dictionary<int, int>();

                // Считаем количество вхождений каждого элемента
                foreach (var item in array)
                {
                    if (countDict.ContainsKey(item))
                    {
                        countDict[item]++;
                    }
                    else
                    {
                        countDict[item] = 1;
                    }
                }

                // Удаляем элементы, которые встречаются более двух раз
                var result = new List<int>();
                foreach (var item in array)
                {
                    if (countDict[item] <= 2)
                    {
                        result.Add(item);
                    }
                }

                return result.ToArray();
            }
        }

        class Program
        {
            static void Main()
            {
                int[] array = { 1, 2, 3, 4, 2, 5, 2, 6, 7, 8, 8, 8, 9 }; // Пример массива
                ArrayProcessor processor = new ArrayProcessor(array);
                int[] result = processor.RemoveElementsOccurringMoreThanTwice();

                Console.WriteLine(string.Join(", ", result));
            }
        }
    }
}
