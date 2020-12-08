using System;

namespace CSH2_Tag_10_Aufgabe_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportler.FühreAktionAus(() => Console.WriteLine("Ich laufe!"));
            Sportler.FühreAktionAus(() => Console.WriteLine("Ich schwimme!"));

            Console.ReadKey(true);
        }
    }
}
