namespace Leetcode.medium
{
    internal class FindMaxFish
    {

        private int max = 0;
        private int count = 0;

        private void DFS(int height, int width, int x, int y, int[][] grid)
        {
            if (!(x > height - 1 || y > width - 1 || y < 0 || x < 0 || grid[x][y] == 0))
            {
                int value = grid[x][y];
                grid[x][y] = 0;
                DFS(height, width, x + 1, y, grid);
                DFS(height, width, x - 1, y, grid);
                DFS(height, width, x, y + 1, grid);
                DFS(height, width, x, y - 1, grid);
                count += value;
            }
        }

        public int Run(int[][] grid)
        {
            int height = grid.Length;
            int width = grid[0].Length;
            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    DFS(height, width, x, y, grid);
                    max = count > max ? count : max;
                    count = 0;
                }
            }
            return max;
        }
    }
}
