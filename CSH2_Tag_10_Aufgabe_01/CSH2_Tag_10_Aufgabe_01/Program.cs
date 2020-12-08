using System;
using System.Collections.Generic;
using System.Text;

namespace CSH2_Tag_10_Aufgabe_01
{
    class Program
    {
        delegate bool MeinRemoveDelegate(string s);
        static void Main(string[] args)
        {
            List<string> SL = new List<string>()
            {
                "Tee",
                "Auto",
                "Beine",
                "Abrakadabra",
                "C# ist nicht die beste Programmiersprache der Welt ..."
            };

            Ausgabe(SL);
            int entfernteElemente = meinRemoveAll(SL, s => s.Length > 5);
            Console.WriteLine(entfernteElemente + " Elemente entfernt....\n");
            Ausgabe(SL);

            Console.ReadKey(true);
        }

        static int meinRemoveAll(List<string> strListe, MeinRemoveDelegate mrd)
        {
            List<string> toRemove = strListe.FindAll(s => mrd(s));

            foreach (string s in toRemove)
                strListe.Remove(s);

            return toRemove.Count;
        }

        static void Ausgabe(List<string> l)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---Ausgabe Liste---");
            int i = 1;
            foreach(string s in l)
            {
                sb.AppendLine($"String Nr.{i}:\t{s}");
                i++;
            }
            sb.AppendLine();
            Console.WriteLine(sb.ToString());
        }
    }
}
