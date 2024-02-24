using System.Text;

namespace _20._02
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Введіть межі числового діапазону, розділених пробілами:");
            string input = Console.ReadLine();
            string[] bounds = input.Split(' ');

            if (bounds.Length != 2)
            {
                Console.WriteLine("Ви повинні  ввести рівно  дві межі!");
                return;
            }

            int lower, upper;
            if (!int.TryParse(bounds[0], out lower) || !int.TryParse(bounds[1], out upper))
            {
                Console.WriteLine("Ви повинні ввести тільки цілі числа!");
                return;
            }

            if (lower < 0 || upper < 0 || lower > upper)
            {
                Console.WriteLine("Ви повинні ввести додатні числа, такі що перше менше або дорівнює другому!");
                return;
            }

            List<int> fibs = new List<int>();
            int a = 0, b = 1;
            while (a <= upper)
            {
                if (a >= lower)
                {
                    fibs.Add(a);
                }
                int c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine("Числа Фібоначчі з діапазону {0}–{1}:", lower, upper);
            foreach (int fib in fibs)
            {
                Console.Write(fib + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        }
    }