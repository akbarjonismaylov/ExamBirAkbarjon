using System;
using System.Collections.Generic;

/*
  1)List<int> berilgan. Juft elementlarini sanab miqdorini qaytaring (funksiya tuzing )
  2)List<string> berilgan. Agar hamma elementlari uzunligi 5 dan katta bo'lsa true aks holda false qaytarsin (funksiya tuzing)
  3)string berilgan. stringni boshidan 3 ta belgisini qaytaring (funksiya tuzing)
  4)string berilgan. Agar string "PDP" bilan boshlansa true aks holda false qaytarsin 
  5)string berilgan. Stringda"G13" bo'lsa true aks holda false qaytaring 
  6)List<int> berilgan. Boshidagi 2 ta elementni yog'indisini hisoblab qaytaruvchi funksiya tuzing
*/
namespace ExamModulOne
{
    internal class Program
    {
        /* static void Main()
         {
             var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
             Console.WriteLine(CountEven(numbers)); 
         }

         public static int CountEven(List<int> numbers)
         {
             if (numbers == null) return 0;
             int count = 0;
             foreach (var n in numbers)
             {
                 if (n % 2 == 0) count++;
             }
             return count;
         }*/

        /*static void Main()
        {
            var text1 = new List<string> { "salom", "hayr", "yaxshimisiz" };
            Console.WriteLine(Five(text1));

            var text2 = new List<string> { "aaaaaa", "ccccc", "vvv" };
            Console.WriteLine(Five(text2));
        }


        public static bool Five(List<string> items)
        {
            if (items == null || items.Count == 0) return false;
            foreach (var s in items)
            {
                if (s == null || s.Length <= 5) return false;
            }
            return true;
        }*/

        /*static void Main()
        {
            Console.Write("String kiriting: ");
            string input = Console.ReadLine();

            string result = Chars(input);
            Console.WriteLine("Natija: " + result);
        }

        static string Chars(string text)
        {
            if (text.Length < 3)
            {
                return text;
            }
            return text.Substring(0, 3);
        }*/

        static void Main()
        {
            Console.Write("String kiriting: ");
            string input = Console.ReadLine();

            bool result = PDP(input);
            Console.WriteLine(result);
        }

        static bool PDP(string text)
        {
            return text.StartsWith("PDP");
        }
    }
}
