using System;
using System.Collections.Generic;
using System.Text;

namespace CSH2_Tag_10_Aufgabe_00
{
    static class Sportler
    {
        public static void FühreAktionAus(Action a)
        {
            a?.Invoke();
        }
    }
}
