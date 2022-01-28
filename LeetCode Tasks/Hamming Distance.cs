namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/hamming-distance/
    public static class HammingDistanceSolution
    {
        public static int HammingDistance(int x,
                                          int y)
        {
            var xor = x ^ y;
            var count = 0;
            
            while (xor != 0)
            {
                xor &= xor - 1;
                count++;
            }

            return count;
        }
    }
}