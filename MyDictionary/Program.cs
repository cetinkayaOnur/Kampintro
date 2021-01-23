using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int> sayilar = new MyDictionary<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            Console.WriteLine(sayilar.Lenght);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(5);
            Console.WriteLine(sayilar.Lenght);
            

        }
    }
}
