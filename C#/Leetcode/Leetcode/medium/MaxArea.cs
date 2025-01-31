namespace Leetcode.medium
{
    internal class MaxArea
    {
        public int Run(int[] height)
        {
            int pointerIndex1 = 0;
            int pointerIndex2 = height.Length - 1;
            int maxArea = 0;
            while (pointerIndex1 < pointerIndex2)
            {
                int area = (pointerIndex2 - pointerIndex1) * (Math.Min(height[pointerIndex1], height[pointerIndex2]));
                maxArea = Math.Max(maxArea, area);
                if (height[pointerIndex1] < height[pointerIndex2]) pointerIndex1++;
                else pointerIndex2--;
            }
            return maxArea;
        }
    }
}
