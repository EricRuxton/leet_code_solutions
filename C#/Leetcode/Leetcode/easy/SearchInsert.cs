namespace Leetcode.easy
{
    internal class SearchInsert
    {

        private int walk(int index, int[] nums, int target)
        {
            if (nums[index] == target || nums[index] > target) return index;

            return walk(index + 1, nums, target);
        }

        public int Run(int[] nums, int target)
        {
            if (nums.Length == 0 || (nums.Length == 1 && nums[0] > target)) return 0;
            if (nums[nums.Length - 1] < target) return nums.Length;
            return walk(0, nums, target);
        }
    }
}
