using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19._12._2021.Extensions
{
    static class Yoxla
    {

        public static bool CheckWord(this string str, string word)
        {
            bool result = false;
            
            string strk = str.ToLower();
            string wordk = word.ToLower();

            if (String.Compare(wordk, strk) == 1)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;

        }
    }
}
