using System;
using System.Collections.Generic;
using System.Text;

namespace CFRM.Domain.Entities
{
    public class Data
    {

        public static string RetornarStringArray(string[] date)
        {
           return string.Join(" ", date);
        }
        
    }
}
