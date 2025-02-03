namespace Leetcode.easy
{
    internal class LongestMonotonicSubarray
    {

        public int Run(int[] nums)
        {
            int fromStart = 1;
            int fromEnd = 1;
            int start = 1;
            int end = nums.Length - 2;
            int longest = 1;
            while (start < nums.Length - 1 || end >= 0)
            {
                if (nums[start] > nums[start - 1])
                {
                    fromStart++;
                    longest = Math.Max(longest, fromStart);
                }
                else
                    fromStart = 1;

                if (nums[end] > nums[end + 1])
                {
                    fromEnd++;
                    longest = Math.Max(longest, fromEnd);
                }
                else
                    fromEnd = 1;

                start++;
                end--;
            }
            return longest;
        }
    }
}
