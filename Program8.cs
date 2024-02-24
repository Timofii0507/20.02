using System.Text;

namespace _20._02
{
    class Program8
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Введіть два числа, розділених пробілами:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            if (numbers.Length != 2)
            {
                Console.WriteLine("Ви повинні ввести рівно два числа!");
                return;
            }

            double value, percent;
            if (!double.TryParse(numbers[0], out value) || !double.TryParse(numbers[1], out percent))
            {
                Console.WriteLine("Ви повинні ввести тільки числа!");
                return;
            }

            double result = value * percent / 100;

            // Виводимо результат на екран
            Console.WriteLine("{0} відсотків від {1} дорівнює {2}", percent, value, result);
            Console.ReadKey();
        }
    }
}
