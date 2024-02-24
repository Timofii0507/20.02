using System.Text;

namespace _20._02
{
    class Program10
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Введіть шестизначне число:");
            string number = Console.ReadLine();

            if (number.Length != 6)
            {
                Console.WriteLine("Помилка: число повинно бути шестизначним!");
                return;
            }

            Console.WriteLine("Введіть два номери розрядів для заміни цифр, розділених пробілами:");
            string input = Console.ReadLine();
            string[] positions = input.Split(' ');

            if (positions.Length != 2)
            {
                Console.WriteLine("Помилка: ви повинні ввести рівно два номери розрядів!");
                return;
            }

            int pos1, pos2;
            if (!int.TryParse(positions[0], out pos1) || !int.TryParse(positions[1], out pos2))
            {
                Console.WriteLine("Помилка: ви повинні ввести тільки цілі числа!");
                return;
            }

            if (pos1 < 1 || pos1 > 6 || pos2 < 1 || pos2 > 6)
            {
                Console.WriteLine("Помилка: номери розрядів повинні бути в діапазоні від 1 до 6!");
                return;
            }

            char[] chars = number.ToCharArray();
            char temp = chars[pos1 - 1];
            chars[pos1 - 1] = chars[pos2 - 1];
            chars[pos2 - 1] = temp;
            string result = new string(chars);

            Console.WriteLine("Число після заміни цифр: {0}", result);
            Console.ReadKey();
        }
    }
}
