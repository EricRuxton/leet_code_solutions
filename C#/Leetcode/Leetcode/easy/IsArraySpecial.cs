namespace Leetcode.easy
{
    internal class IsArraySpecial
    {
        public bool Run(int[] nums)
        {
            if (nums.Length == 2) return ((nums[0] % 2) + (nums[1] % 2) == 1) ? true : false;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if ((nums[i] % 2) + (nums[i + 1] % 2) != 1) return false;
            }
            return true;
        }
    }
}
