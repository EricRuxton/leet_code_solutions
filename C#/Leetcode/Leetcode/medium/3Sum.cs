namespace Leetcode.medium
{
    internal class _3Sum
    {

        public IList<IList<int>> Run(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> list = [];
            for (int i = 0; i < nums.Length; i++)
            {
                int leftIndex = i + 1;
                int rightIndex = nums.Length - 1;
                while (leftIndex < rightIndex)
                {
                    int result = nums[i] + nums[leftIndex] + nums[rightIndex];
                    if (result == 0)
                    {
                        IList<int> newList = [nums[i], nums[leftIndex], nums[rightIndex]];
                        if (!list.Any(l => l.SequenceEqual(newList)))
                        {
                            list.Add(newList);
                        }
                        rightIndex--;
                        leftIndex++;
                    }
                    else if (result > 0)
                    {
                        rightIndex--;
                    }
                    else
                    {
                        leftIndex++;
                    }
                }
            }
            return list;
        }
    }
}
