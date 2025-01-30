namespace Leetcode.easy
{
    internal class AddBinary
    {
        public string Run(string a, string b)
        {
            int longer = Math.Max(a.Length, b.Length);
            a = a.PadLeft(longer, '0');
            b = b.PadLeft(longer, '0');
            string c = string.Empty;
            int carry = 0;
            char? lastA = a.Last();
            char? lastB = b.Last();
            while (lastA != null || lastB != null || carry != 0)
            {
                char digit;
                if (lastA == null)
                {
                    digit = '1';
                    carry = 0;
                }
                else if (lastA == '0' && lastB == '0')
                {
                    digit = carry == 0 ? '0' : '1';
                    carry = 0;
                }
                else if (lastA == '1' && lastB == '1')
                {
                    digit = carry == 1 ? '1' : '0';
                    carry = 1;
                }
                else
                {
                    digit = carry == 1 ? '0' : '1';
                    carry = digit == '0' ? 1 : 0;
                }
                c += digit;
                if (a.Length > 0)
                {
                    a = a.Substring(0, a.Length - 1);
                    b = b.Substring(0, b.Length - 1);
                }
                lastA = a.Length > 0 ? a.Last() : null;
                lastB = b.Length > 0 ? b.Last() : null;
            }
            return string.Join("", c.ToArray().Reverse());
        }
    }
}
