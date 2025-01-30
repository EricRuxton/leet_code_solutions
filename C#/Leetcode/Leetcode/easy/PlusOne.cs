namespace Leetcode.easy
{
    internal class PlusOne
    {
        public int[] Run(int[] digits)
        {
            int currIndex = digits.Length - 1;
            while (true)
            {
                if (digits[currIndex] == 9)
                {
                    digits[currIndex] = 0;
                    if (currIndex == 0)
                    {
                        int[] output = { 1 };
                        return [.. output, .. digits];
                    }
                }
                else
                {
                    digits[currIndex] += 1;
                    break;
                }
                currIndex--;
            }
            return digits;
        }
    }
}
