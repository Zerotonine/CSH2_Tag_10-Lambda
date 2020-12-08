using System;
using System.Text;

namespace CSH2_Tag_10_Aufgabe_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "Autobahnpolizist", "Grundstücksverkehrsgenehmigungszuständigkeitsübertragungsverordnung", "Ja" };
            Ausgabe(strings);

            Sortiere(ref strings, (s1, s2) => s1.Length > s2.Length);
            Ausgabe(strings);

            Console.ReadKey(true);
        }

        static void Sortiere(ref string[] arr, Func<string, string, bool> func)
        {
            string temp;
            for (int i = 0; i < arr.Length -2; i++)
            {
                for(int j = 0; j < arr.Length -2; j++)
                {
                    if(func(arr[j+1], arr[j]))
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void Ausgabe(in string[] arr)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---Ausgabe Array---");
            int i = 1;
            foreach(string s in arr)
            {
                sb.AppendLine($"String Nr. {i}:\t{s}");
                i++;
            }
            sb.AppendLine();
            Console.WriteLine(sb.ToString());
        }
    }
}
