using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTester
{
    public class ReverseString
    {
        public string Reverse(string s)
        {
            if (s == null)
                return null;
            if (s.Length == 0)
                return String.Empty;



            char[] r = new char[s.Length]; { }
            for (int i = 0; i < s.Length; i++)
            {
                r[i] = s[s.Length - i - 1];
            }

            string result = new string(r);
            return result;

        }
    }
}
