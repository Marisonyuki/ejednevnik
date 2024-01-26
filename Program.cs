using System.Text;

namespace Ejednevnik
{
    internal class Program
    {
        static void Main()
        {
            int pos = 2;
            DateTime ForDate1 = new DateTime(2023, 05, 06);
            string date1 = ForDate1.ToShortDateString();
            DateTime ForDate2 = new DateTime(2023, 05, 08);
            string date2 = ForDate2.ToShortDateString();
            DateTime ForDate3 = new DateTime(2023, 05, 13);
            string date3 = ForDate3.ToShortDateString();
            int page = 1;
            int amount = 2;
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                if (key.Key == ConsoleKey.LeftArrow && page != 1)
                {
                    page--;
                }
                if (key.Key == ConsoleKey.RightArrow && page != 3)
                {
                    page++;
                }
                if (page == 1)
                {
                    amount = 2;
                }
                if (page == 2)
                {
                    amount = 2+1;
                }
                if (page == 3)
                {
                    amount = 2+1;
                }
                Strelka(pos, page, amount, key, date1, date2, date3);
                pos = Strelka(pos, page, amount, key, date1, date2, date3);
                key = Console.ReadKey();
            }
        }


        static void Menu(int page, string date1, string date2, string date3)
        {
            Console.WriteLine("Заметки");
            if (page == 1)
            {
                Console.WriteLine(date1);
                Console.WriteLine("  1. Выйти из дома");
            }
            if (page == 2)
            {
                Console.WriteLine(date2);
                Console.WriteLine("  1. Войти в дом");
                Console.WriteLine("  2. Лягушка");
            }
            if (page == 3)
            {
                Console.WriteLine(date3);
                Console.WriteLine("  1. Сделать дела");
                Console.WriteLine("  2. Не сделать дела");
            }
        }
        static int Strelka(int pos, int page, int amount, ConsoleKeyInfo key, string date1, string date2, string date3)
        {
            if (key.Key == ConsoleKey.UpArrow && pos != 2)
            {
                pos--;
            }
            if (key.Key == ConsoleKey.DownArrow && pos != amount)
            {
                pos++;
            }
            Console.Clear();
            Menu(page, date1, date2, date3);
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            return pos;
        }

        static void Info()
        {

        }
    }
}