using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTasksLibrary
{
    public static class RomanNum
    {

        static int i;
        static string ch;
        static int result = 0;
        static int new_value = 0;
        static int old_value = 0;
        static Dictionary<int, string> ra = new Dictionary<int, string>
            {
                { 1000, "M" },  { 500, "D" }, { 100, "C" }, { 50 , "L" },
                { 10 , "X" }, { 5  , "V" },  { 1  , "I" }
            };

        public static int RomanToArabic(string roman)
        {
            if (roman.Length == 0) return -1;

            if (roman.Length >= 4)
            {
                if (roman[0] == 'M' & roman[1] == 'M' & roman[2] == 'M') return -3;

                for (i = 3; (i < roman.Length); i++)
                {
                    if ((roman[i - 1] & roman[i - 2] & roman[i - 3]) == roman[i])
                        return -2;
                }
            }

            for (i = 1; (i <= roman.Length); i++)
            {
                ch = roman.Substring((i - 1), 1).ToUpper();
                new_value = ra.FirstOrDefault(x => x.Value == ch).Key;

                if (new_value == 0)
                    return -4;

                result = new_value > old_value ?
                    (result += new_value - 2 * old_value) : (result += new_value);

                old_value = new_value;
            }

            return result;
        }

    }
}
