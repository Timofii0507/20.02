using System.Text;

namespace _20._02
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Введіть довжину лінії:");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть символ заповнювач:");
            char symbol = char.Parse(Console.ReadLine());
            Console.WriteLine("Введіть напрямок лінії (горизонтальна або вертикальна):");
            string direction = Console.ReadLine();

            if (direction == "горизонтальна")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            else if (direction == "вертикальна")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(symbol);
                }
            }
            else
            {
                Console.WriteLine("Невірний напрямок лінії!");
                Console.ReadKey();
            }
        }
    }
}