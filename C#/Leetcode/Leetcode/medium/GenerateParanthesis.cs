namespace Leetcode.medium
{
    internal class GenerateParanthesis
    {
        IList<string> outs = [];
        private void GeneratePairs(int n, string brackets)
        {
            if (brackets.Count(b => b.ToString() == "(") == n &&
                brackets.Count(b => b.ToString() == ")") == n)
            {
                outs.Add(brackets);
            }
            if (brackets.Count(b => b.ToString() == "(") < n)
            {
                GeneratePairs(n, brackets + "(");
            }
            if (brackets.Count(b => b.ToString() == ")") < n &&
                brackets.Count(b => b.ToString() == ")") < brackets.Count(b => b.ToString() == "("))
            {
                GeneratePairs(n, brackets + ")");
            }

        }


        public IList<string> Run(int n)
        {
            GeneratePairs(n, "(");
            return outs;
        }
    }
}
