using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            int[] array = { 1, 2, 3, 4, 5, 1, 2, 3 };

            int evenCount = 0;
            int oddCount = 0;
            int uniqueCount = 0;

            foreach (int element in array)
            {
                if (element % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && array[i] == array[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    uniqueCount++;
                }
            }

            Console.WriteLine($"Кількість парних чисел: {evenCount}");
            Console.WriteLine($"Кількість непарних чисел: {oddCount}");
            Console.WriteLine($"Кількість унікальних чисел: {uniqueCount}");
            Console.ReadKey();
        }
    }
}
