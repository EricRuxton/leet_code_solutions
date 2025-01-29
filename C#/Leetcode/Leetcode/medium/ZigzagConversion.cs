namespace Leetcode.medium
{
    internal class ZigzagConversion
    {

        public string Run(string s, int numRows)
        {
            if (numRows == 1) return s;
            string zigzag = string.Empty;
            int rowLength = (numRows - 1) * 2;
            bool increasing = true;
            int index = 0;
            string[] dict = new string[numRows];
            for (int i = 0; i < s.Length; i++)
            {
                if (dict[index] == null) dict[index] = s[i].ToString();
                else dict[index] += s[i].ToString();
                if (index == 0)
                {
                    increasing = true;
                }
                else if (index == numRows - 1)
                {
                    increasing = false;
                }
                index = (increasing) ? ++index : --index;
            }
            return string.Join("", dict);
        }
    }
}
