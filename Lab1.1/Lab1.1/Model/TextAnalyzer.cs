using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1._1.Model
{
    public class TextAnalyzer
    {
        //Beräknar och returnerar antalet versaler i en sträng
        public static int GetNumberOfCapitals(string text)
        {
            int counter = 0;        //Versalräknare
            foreach (Char ch in text)
            {
                if (Char.IsUpper(ch))
                {
                    counter += 1;
                }
            }

            return counter;
        }
    }
}