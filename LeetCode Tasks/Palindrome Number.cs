﻿namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/palindrome-number/
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || x % 10 == 0 && x != 0)
            {
                return false;
            }

            var reverse = 0;
            while (x > reverse)
            {
                reverse = reverse * 10 + x % 10;
                x /= 10;
            }

            return x == reverse || x == reverse / 10;
        }
    }
}