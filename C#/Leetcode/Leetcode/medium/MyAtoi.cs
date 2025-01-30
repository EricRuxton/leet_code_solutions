namespace Leetcode.medium
{
    internal class MyAtoi
    {
        public int Run(string s)
        {
            string sanitized = s.Trim();
            if (sanitized.Length == 0) return 0;
            List<int> outArray = [];
            string actualNum = string.Empty;
            for (int i = 0; i < sanitized.Length; i++)
            {
                if ((sanitized[i] == '-' || sanitized[i] == '+') && i == 0) actualNum += sanitized[i];
                else if (int.TryParse(sanitized[i].ToString(), out int result))
                {
                    actualNum += sanitized[i];
                    if (Int64.TryParse(actualNum, out long whole))
                    {
                        if (whole > (Math.Pow(2, 31) - 1)) return (int)(Math.Pow(2, 31) - 1);
                        if (whole < Math.Pow(-2, 31)) return (int)Math.Pow(-2, 31);
                    }
                }
                else
                {
                    return actualNum.Length > 0 ? int.TryParse(actualNum, out int output) ? output : 0 : 0;
                }
            }
            return int.TryParse(actualNum, out int output2) ? output2 : 0;
        }
    }
}
