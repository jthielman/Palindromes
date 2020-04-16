using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromes
{
    public class PalindromeChecker
    {
        public bool Check(string inputString)
        {
            int min = 0;
            int max = inputString.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = inputString[min];
                char b = inputString[max];

                while (!char.IsLetterOrDigit(a))
                {
                    min++;
                    if (min > max)
                    {
                        return true;
                    }
                    a = inputString[min];
                }

                while (!char.IsLetterOrDigit(b))
                {
                    max--;
                    if (min > max)
                    {
                        return true;
                    }
                    b = inputString[max];
                }

                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
