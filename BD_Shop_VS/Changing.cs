using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Shop_VS
{
    public static class Changing<T>
    {
        public static string dmy = "ser Dataformat dmy";

        public static void Rewrite(T number)
        {
            char[] str = number.ToString().ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ',')
                    str[i] = '.';

                if (str[i] == '\'')
                    str[i] = '"';
            }

        }
    }
}
