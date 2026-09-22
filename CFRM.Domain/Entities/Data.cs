using System;
using System.Collections.Generic;
using System.Text;

namespace CFRM.Domain.Entities
{
    public class Data
    {

        public static string RetornarStringArray(string[] date)
        {
            string frase = string.Empty;
            for (int i = 0; i < date.Length; i++)
            {
                frase += date[i] + " " ;
            }
           return frase.Trim();
        }
        
    }
}
