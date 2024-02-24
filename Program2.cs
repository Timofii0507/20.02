using System.Text;
using System;

namespace _20._02
{
    class Prorgram
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть п'ять чисел, розділених пробілами:");
            string input = Console.ReadLine();
            string[] num = input.Split(' ');

            if (num.Length != 5)
            {
                Console.WriteLine("Ви повинні  ввест рівно п'ять чисел!");
                return;
            }

            double[] nums = new double[5];
            for (int i = 0; i < 5; i++)
            {
                if (!double.TryParse(num[i], out nums[i]))
                {
                    Console.WriteLine("Ви повинні ввести тільки числа!");
                    return;
                }
            }

            double sum = 0;
            double max = nums[0];
            double min = nums[0];
            double product = 1;
            for (int i = 0; i < 5; i++)
            {
                sum += nums[i];
                max = Math.Max(max, nums[i]);
                min = Math.Min(min, nums[i]);
                product *= nums[i];
            }
            Console.WriteLine("Сума чисел: {0}", sum);
            Console.WriteLine("Максимум з п'яти чисел: {0}", max);
            Console.WriteLine("Мінімум з п'яти чисел: {0}", min);
            Console.WriteLine("Добуток чисел: {0}", product);
            Console.ReadKey();
        }
    }
}
