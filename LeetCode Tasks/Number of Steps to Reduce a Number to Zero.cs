namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
    public static class NumberOfStepsToReduceANumberToZero
    {
        public static int NumberOfSteps(int num)
        {
            if(num == 0)
                return 0;
            
            var result = 0;
            while (num > 0)
            {
                result += (num & 1) + 1;
                num >>= 1;
            }

            return result - 1;
        }
    }
}