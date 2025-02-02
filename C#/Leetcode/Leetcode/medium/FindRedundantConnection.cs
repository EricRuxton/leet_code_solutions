namespace Leetcode.medium
{
    internal class FindRedundantConnection
    {
        private bool isLoop(Dictionary<int, List<int>> adjacencyList, List<int> adjacencies, List<int> loop, int? last)
        {
            foreach (int adjacency in adjacencies)
            {
                if (adjacency != last)
                {
                    if (loop.Contains(adjacency)) return true;
                    loop.Add(adjacency);
                    List<int> newAdjcencies = adjacencyList.TryGetValue(adjacency, out List<int>? adj) ? adj : [];
                    if (newAdjcencies.Count > 0)
                        isLoop(adjacencyList, adjacencyList[adjacency], loop, adjacency);
                }

            }
            return false;
        }

        public int[] Run(int[][] edges)
        {
            Dictionary<int, List<int>> adjacencyList = [];
            foreach (int[] edge in edges)
            {
                if (adjacencyList.TryGetValue(edge[0], out List<int>? trusters1))
                {
                    trusters1.Add(edge[1]);
                }
                else
                {
                    adjacencyList[edge[0]] = [edge[1]];
                }

                if (adjacencyList.TryGetValue(edge[1], out List<int>? trusters2))
                {
                    trusters2.Add(edge[0]);
                }
                else
                {
                    adjacencyList[edge[1]] = [edge[0]];
                }

                foreach (KeyValuePair<int, List<int>> adjacency in adjacencyList)
                {
                    List<int> loop = [adjacency.Key];
                    if (isLoop(adjacencyList, adjacency.Value, loop, null)) return edge;
                }
            }
            return [0];
        }
    }
}
