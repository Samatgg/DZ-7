using System;
using System.Collections.Generic;

namespace Тумаков_8лаб
{
    class Program
    {
        static string Reverse(string input) // Для упр 8.2
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        static string FormatAsIFormattable(object obj) // Для упр 8.4
        {
            if (obj is IFormattable formattableObj)
            {                
                IFormattable formattable = obj as IFormattable;
                string formattedString = formattable.ToString(null, null);
                return formattedString;
            }

            return null;
        }
        static void Main(string[] args)
        {
            // Упр 8.1 - Mетод, который переводит деньги с одного счета на другой.
            Console.WriteLine("Упр 8.1 - Метод, который переводит деньги с одного счета на другой\n");
            BankAccount account1 = new BankAccount { AccountNumber = "1", Balance = 2345 };
            BankAccount account2 = new BankAccount { AccountNumber = "2", Balance = 212 };
            Console.WriteLine("Введите сумму, которую хотите перевести");
            decimal sum;
            bool a = decimal.TryParse(Console.ReadLine(), out sum);
            if (a) 
            {
                account1.TransferMoney(account2, sum);
            }
            else
            {
                Console.WriteLine("Некорректно ввели сумму");
            }

            // Упр 8.2 - Метод,который принимает строку и возвращает эту же строку в обратном порядке
            Console.WriteLine("\nУпр 8.2 - Метод,который принимает строку и возвращает эту же строку в обратном порядке\n");
            Console.WriteLine("Напишите какое-либо предложение или набор букв:");
            string text = Console.ReadLine();        
            string reversed = Reverse(text);
            Console.WriteLine(reversed);

            // Упр 8.4 - Метод, который проверяет реализует ли входной параметр метода интерфейс System.IFormattable.
            Console.WriteLine("\nУпр 8.4 - Метод, который проверяет реализует ли входной параметр метода интерфейс System.IFormattable\n");
            int number = 42;
            string formattedNumber = FormatAsIFormattable(number);

            if (formattedNumber != null)
            {
                Console.WriteLine("Входной параметр реализует интерфейс IFormattable.");
                Console.WriteLine("Результат форматирования: " + formattedNumber);
            }
            else
            {
                Console.WriteLine("Входной параметр не реализует интерфейс IFormattable.");
            }

            // Дз упр 2 - Песни,исполнители,сравнить первую и вторую песню

            Console.WriteLine("\nДз упр 2 - Песни,исполнители,сравнить первую и вторую песню\n");
            Song song1 = new Song("Пополам", "MACAN");
            Song song2 = new Song("KARI", "BigBabyTape",song1);
            Song song3 = new Song("Раньше", "Jamik",song2);
            Song song4 = new Song("Патрон", "Miyagi",song3);
            List<Song> songList = new List<Song> { song1, song2, song3, song4 };
            if (song1.Equals(song2))
            {
                Console.WriteLine("Песни одинаковые");
            }
            else
            {
                Console.WriteLine("Песни разные");
            }
            foreach (Song song in songList)
            {
                Console.WriteLine(song.Title);
            }          
        }       
    }
}
