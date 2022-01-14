using System;

namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/decompress-run-length-encoded-list/
    public class DecompressRunLengthEncodedList
    {
        public int[] DecompressRLElist(int[] nums)
        {
            var resultArrayLength = 0;
            for (var i = 0; i < nums.Length; i += 2)
            {
                resultArrayLength += nums[i];
            }

            var result = new int[resultArrayLength];
            
            var startIndex = 0;
            for (var i = 0; i < nums.Length; i += 2)
            {
                var freq = nums[i];
                var val = nums[i + 1];

                Array.Fill(result, val, startIndex, freq);
                
                startIndex += freq;
            }

            return result;
        }
    }
}