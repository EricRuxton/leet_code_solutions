namespace Leetcode.easy
{
    internal class SquareRoot
    {

        public int Run(int x)
        {
            int iterations = 0;
            for (int i = 1; x > 0; i += 2)
            {
                if (x >= i) x -= i;
                else break;
                iterations++;
            }
            return iterations;
        }
    }
}
