using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTasksLibrary
{
    public static class BalancedBracket
    {
        static Stack<char> skob = new Stack<char>();

        public static bool Balanced(string s)
        {
            for (int i = 0; (i < s.Length); i++)
            {
                switch (s[i])
                {
                    case '(':
                        skob.Push(s[i]);
                        break;
                    case ')':

                        try
                        {
                            skob.Pop();
                        }
                        catch
                        {
                            return false;
                        }

                        break;
                    default:
                        break;
                }
            }
            return skob.Count == 0 ? true : false;
        }

    }
}
