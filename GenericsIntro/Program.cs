using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("ONUR");

            Console.WriteLine(isimler.Lenght);

            isimler.Add("Engin");

            Console.WriteLine(isimler.Lenght);
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);

            }

        }
    }
}
