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
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Text(text);
        }

        static void Text(string text)
        {
            for (int i = 0; i < text.Length - 3; i++)
            {
                char c = text[i];
            }
        }

    }
}
