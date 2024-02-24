using System.Text;

namespace _20._02
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Два цілі додатні числа через  пробіл:");
            string input = Console.ReadLine();
            string[] num = input.Split(' ');

            if (num.Length != 2)
            {
                Console.WriteLine("Ви повинні ввести  рівно два числа!");
                return;
            }

            if (num.Length != 2)
            {
                Console.WriteLine("Ви повинні ввести рівно два числа!");
                return;
            }

            int a, b;
            if (!int.TryParse(num[0], out a) || !int.TryParse(num[1], out b))
            {
                Console.WriteLine("Ви повинні ввести тільки цілі числа!");
                return;
            }

            if (a <= 0 || b <= 0 || a >= b)
            {
                Console.WriteLine("Ви повинні ввести додатні числа, такі що перше менше другого!");
                return;
            }

            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}