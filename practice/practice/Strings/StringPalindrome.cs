using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Strings
{
    public class StringPalindrome
    {
        public void FindPalindrome()
        {
            string s = "ABCBA";

            int left = 0;
            int right = s.Length - 1;
            bool isPalindrome = true;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    isPalindrome = false;
                }

                left++;
                right--;
            }

            Console.WriteLine(isPalindrome ? "string is palindrome" : "string is not palindrome");
        }
    }
}
