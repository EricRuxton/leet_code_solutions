namespace Leetcode.easy
{
    internal class FindJudge
    {

        public int Run(int n, int[][] trust)
        {
            if (n == 1 && trust.Length == 0) return 1;
            Dictionary<int, List<int>> trustMatrix = new Dictionary<int, List<int>>();
            List<int> citizens = [];
            foreach (int[] trustPair in trust)
            {
                if (!citizens.Contains(trustPair[0])) citizens.Add(trustPair[0]);
                if (!citizens.Contains(trustPair[1])) citizens.Add(trustPair[1]);
                if (trustMatrix.TryGetValue(trustPair[0], out List<int>? trusters))
                {
                    trusters.Add(trustPair[1]);
                }
                else
                {
                    trustMatrix[trustPair[0]] = [trustPair[1]];
                }
            }
            int[] judge = citizens.Where(c => !trustMatrix.ContainsKey(c)).ToArray();

            if (judge.Length != 1) return -1;

            var nonTrusters = trustMatrix.Where(c => !c.Value.Contains(judge[0])).ToList();

            if (nonTrusters.Count != 0) return -1;

            else return judge[0];
        }
    }
}
