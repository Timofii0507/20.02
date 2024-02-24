using System.Text;

namespace _20._02
{
    class Program11
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Введіть дату у форматі дд.мм.рррр:");
            string input = Console.ReadLine();

            DateTime date;
            if (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out date))
            {
                Console.WriteLine("Помилка: невірний формат дати!");
                return;
            }

            string season;
            switch (date.Month)
            {
                case 12:
                case 1:
                case 2:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    season = "Unknown";
                    break;
            }

            string day = date.DayOfWeek.ToString();

            Console.WriteLine("{0} {1}", season, day);
            Console.ReadKey();
        }
    }
}
