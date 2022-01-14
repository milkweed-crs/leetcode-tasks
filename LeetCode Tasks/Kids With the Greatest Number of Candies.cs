using System.Collections.Generic;
using System.Linq;

namespace LeetCode_Tasks
{
    // https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
    public static class KidsWithTheGreatestNumberOfCandies
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies) 
        {
            var max = candies.Max();
            
            return candies.Select(candy => candy + extraCandies >= max).ToList();
        }
    }
}