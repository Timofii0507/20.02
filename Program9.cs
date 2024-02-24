using System.Text;

namespace _20._02
{
    class Program9
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Введіть чотири цифри, розділених пробілами:");
            string input = Console.ReadLine();
            string[] digits = input.Split(' ');

            if (digits.Length != 4)
            {
                Console.WriteLine("Ви повинні ввести рівно чотири цифри!");
                return;
            }

            int number = 0;
            for (int i = 0; i < 4; i++)
            {
                int digit;
                if (!int.TryParse(digits[i], out digit))
                {
                    Console.WriteLine("Ви повинні ввести тільки цифри!");
                    return;
                }
                if (digit < 0 || digit > 9)
                {
                    Console.WriteLine("Ви повинні ввести цифри в діапазоні від 0 до 9!");
                    return;
                }
                number = number * 10 + digit;
            }

            Console.WriteLine("Число, яке містить ці цифри: {0}", number);
            Console.ReadKey();
        }
    }
}
