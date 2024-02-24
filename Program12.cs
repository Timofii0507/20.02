using System.Text;

namespace _20._02
{
    class Program12
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Введіть показання температури:");
            double temperature = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть 1, якщо хочете конвертувати з Фаренгейта в Цельсій, або 2, якщо навпаки:");
            int choice = int.Parse(Console.ReadLine());

            double result;
            if (choice == 1)
            {
                result = (temperature - 32) * 5 / 9;
                Console.WriteLine("{0} градусів Фаренгейта дорівнює {1} градусів Цельсія", temperature, result);
            }
            else if (choice == 2)
            {
                result = temperature * 9 / 5 + 32;
                Console.WriteLine("{0} градусів Цельсія дорівнює {1} градусів Фаренгейта", temperature, result);
            }
            else
            {
                Console.WriteLine("Помилка: ви повинні ввести 1 або 2!");
                Console.ReadKey();
            }
        }
    }
}
