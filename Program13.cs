using System.Text;

namespace _20._02
{
    class Program13
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Введіть два числа, розділених пробілами:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            if (numbers.Length != 2)
            {
                Console.WriteLine("Помилка: ви повинні ввести рівно два числа!");
                return;
            }

            int a, b;
            if (!int.TryParse(numbers[0], out a) || !int.TryParse(numbers[1], out b))
            {
                Console.WriteLine("Помилка: ви повинні ввести тільки цілі числа!");
                return;
            }

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine("Парні числа у діапазоні від {0} до {1}:", a, b);
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
