using System;

namespace lab3
{
    class Program
    {
        static long ExponentiationIs (int a, int b)
        {
            return Convert.ToInt64(Math.Pow(a, b));
        }
        static int CountingOfSpaces (long a)
        {
            string str = Convert.ToString(a);
            int spacesCount = str.Length;
            return spacesCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение диапазона");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите последнее значение диапазона");
            int xn = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите параметр");
            int inc = int.Parse(Console.ReadLine());
            long maxElement = 0;

            int[] array = new int[Math.Abs(xn - x1)-1];
            for (int i = 0; i < array.Length; i++)
            {
                if (x1 < xn)
                {
                    array[i] = x1 + i + 1 + inc;
                }
                else
                {
                    array[i] = x1 - i - 1 + inc;
                }

                if (i == 0)
                {
                    maxElement = CountingOfSpaces(array[i]);
                }

                if (maxElement < CountingOfSpaces(ExponentiationIs(array[i], i)))
                {
                    maxElement = CountingOfSpaces(ExponentiationIs(array[i], i));
                }
            }

            string str = "  "; //2 пробела

            while (maxElement > 0)
            {
                str = str + " ";
                maxElement = maxElement - 1;
            }

            Console.WriteLine("увеличение на " + inc + " и возведение в степень I");

            for (int i = 0; i < array.Length; i++)
            {
                string firstColoumn = str.Substring(0, str.Length - CountingOfSpaces(array[i]));
                string secondColoumn = str.Substring(0, str.Length - CountingOfSpaces(ExponentiationIs(array[i], i)));
                Console.WriteLine(
                    ("|"+ firstColoumn.Substring(0, firstColoumn.Length / 2) 
                    + (array[i]) 
                    + firstColoumn.Substring(firstColoumn.Length / 2) + "|")

                    + (secondColoumn.Substring(0, secondColoumn.Length / 2) 
                    + (ExponentiationIs(array[i], i)) 
                    + secondColoumn.Substring(secondColoumn.Length / 2) + "|"));
            }
        }
    }
}
