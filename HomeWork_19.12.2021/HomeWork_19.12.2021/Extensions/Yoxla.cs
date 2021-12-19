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
            int m;
            m = strk.IndexOf(wordk,0, strk.Length - 1);
            if (m==1)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;

            

        }
    }
}
