namespace Leetcode.easy
{
    internal class LengthOfLastWord
    {

        public int Run(string s)
        {
            string[] words = s.Trim().Split(' ');
            return words.Last().Length;
        }
    }
}
