using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kursu";
            string kurs2 = "Programlamaya Giriş Kursu";
            string kurs3 = "Java";
            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Kursu" , "Programlamaya Giriş Kursu", "Java","Python","C#"};  
            for (int i = 0; i<kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti.");
                
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu - Footer");

        }

    }
}
