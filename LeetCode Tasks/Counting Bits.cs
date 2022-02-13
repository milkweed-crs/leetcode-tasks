namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/counting-bits/
    public class CountingBits
    {
        public int[] CountBits(int n)
        {
            var result = new int[n + 1];
            
            var pow = 1;
            
            for (int i = 1, t = 0; i <= n; i++, t++)
            {
                if (i == pow)
                {
                    pow *= 2;
                    t = 0;
                }

                result[i] = result[t] + 1;
            }

            return result;
        }
    }
}