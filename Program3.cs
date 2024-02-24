using System.Text;

namespace _20._02
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Введіть шестизначне число: ");
            string input = Console.ReadLine();

            if (input.Length !=6)
            {
                Console.WriteLine("Ви повинні  ввести шестизначне число!");
                return;
            }

            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            string output = new string(chars);

            Console.WriteLine("Перевернуте число: {0}", output);
            Console.ReadKey();
        }
    }
}
