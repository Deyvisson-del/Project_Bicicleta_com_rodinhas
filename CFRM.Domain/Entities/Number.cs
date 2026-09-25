using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CFRM.Domain.Entities
{
    public class Number
    {

        public static string ConversorRomanoIndoArabico(string input)
        {
            string[] NumerosRomanos = { "X", "I", "C", "M", "L", "V" };
            int numero = 0;
            for (int i = 0; i <= 0; i++)       
                if (true)
                {
                    if (input == NumerosRomanos[0].ToLowerInvariant())
                    {
                        numero += 10;
                    }
                    if (input.Contains(NumerosRomanos[1].ToLowerInvariant()))
                    {
                        numero++;
                    }
                    if (input.Contains(NumerosRomanos[2].ToLowerInvariant()))
                    {
                        numero += 100;
                    }
                    if (input.Contains(NumerosRomanos[3].ToLowerInvariant()))
                    {
                        numero += 1000;
                    }
                    if (input.Contains(NumerosRomanos[4].ToLowerInvariant()))
                    {
                        numero += 50;
                    }
                    if (input.Contains(NumerosRomanos[5].ToLowerInvariant()))
                    {
                        numero += 5;
                    }
                }
                

            return $"O número é {numero}";
        }
    }
}
