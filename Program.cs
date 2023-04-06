using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkk1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hangi işlemi yapmak istersiniz?");
                Console.WriteLine("1 - Çift sayıları bulma");
                Console.WriteLine("2 - Bölünebilir sayıları bulma");
                Console.WriteLine("3 - Kelimeleri ters çevirme");
                Console.WriteLine("4 - Kelime ve harf sayısını bulma");
                Console.WriteLine("0 - Çıkış");

                string input = Console.ReadLine();
                int choice;
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Lütfen geçerli bir seçim yapınız.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        FindEvenNumbers();
                        break;
                    case 2:
                        FindDivisibleNumbers();
                        break;
                    case 3:
                        ReverseWords();
                        break;
                    case 4:
                        PrintWordAndCharCounts();
                        break;
                    case 0:
                        Console.WriteLine("Çıkış yapılıyor...");
                        return;
                    default:
                        Console.WriteLine("Lütfen geçerli bir seçim yapınız.");
                        break;
                }
            }
        }

        static void FindEvenNumbers()
        {
            Console.Write("Kaç sayı gireceksiniz? ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Lütfen pozitif sayıları giriniz:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Çift sayılar:");
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }

        static void FindDivisibleNumbers()
        {
            Console.Write("Kaç sayı gireceksiniz? ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Bölünecek sayıyı giriniz: ");
            int m = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Lütfen pozitif sayıları giriniz:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"{m} sayısına tam bölünen veya eşit olan sayılar:");
            foreach (int number in numbers)
            {
                if (number % m == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }

        static void ReverseWords()
        {
            Console.Write("Kaç kelime gireceksiniz? ");
            int n = int.Parse(Console.ReadLine());

            string[] words = new string[n];

            Console.WriteLine("Lütfen kelimeleri giriniz:");
            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }

            Console.WriteLine("Kelime ters çevirme:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }
        }

        static void PrintWordAndCharCounts()
        {
            Console.Write("Lütfen bir cümle girin: ");
            string sentence = Console.ReadLine();

            int wordCount = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int charCount = sentence.Length;

            Console.WriteLine($"Girilen cümle {wordCount} kelime ve {charCount} harf içeriyor.");
        }
    }
}
