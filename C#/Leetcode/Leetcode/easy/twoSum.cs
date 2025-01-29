namespace Leetcode.easy
{
    internal class TwoSum
    {

        public int[] Run(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    return [dict[nums[i]], i];
                }
                dict[target - nums[i]] = i;
            }
            return [];
        }
    }
}
