using System;

namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
    public class SubtractTheProductAndSumOfDigitsOfAnInteger
    {
        public int SubtractProductAndSum(int n)
        {
            var charSpan = n.ToString().AsSpan();
            var product = 1;
            var sum = 0;
            
            foreach (var ch in charSpan)
            {
                var intValue = int.Parse(ch.ToString());
                product *= intValue;
                sum += intValue;
            }

            return product - sum;
        }
    }
}