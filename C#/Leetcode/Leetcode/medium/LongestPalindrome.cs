namespace Leetcode.medium
{
    internal class LongestPalindrome
    {
        private static string FindPalindrome(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return s.Substring(left + 1, right - (left + 1));
        }

        public string Run(string s)
        {
            if (s.Length == 1) return s;
            Dictionary<string, bool> palindromeDictionary = new Dictionary<string, bool>();
            string longestPalindrome = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                longestPalindrome = FindPalindrome(s, i, i).Length > longestPalindrome.Length ? FindPalindrome(s, i, i) : longestPalindrome;
                longestPalindrome = FindPalindrome(s, i, i + 1).Length > longestPalindrome.Length ? FindPalindrome(s, i, i + 1) : longestPalindrome;
            }
            return longestPalindrome;
        }


        //Works but very slow
        //private static bool IsPalindrome(string s)
        //{
        //    int half = s.Length / 2;
        //    string first = s.Substring(0, half);
        //    string second = string.Join("", s.Substring(s.Length - half).ToCharArray().Reverse());
        //    return first.Equals(second);
        //}

        //public string Run(string s)
        //{

        //    Dictionary<string, bool> palindromeDictionary = new Dictionary<string, bool>();
        //    if (s.Length == 1) return s;
        //    string longestPalindrome = s[0].ToString();
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        string palindrome = s[i].ToString();
        //        palindromeDictionary.Add(palindrome, true);
        //        for (int j = 1; j < s.Length; j++)
        //        {
        //            if (i + j < s.Length)
        //            {
        //                palindrome += s[i + j].ToString();
        //                if (!palindromeDictionary.ContainsKey(palindrome))
        //                {
        //                    if (IsPalindrome(palindrome))
        //                    {
        //                        palindromeDictionary.Add(palindrome, true);
        //                        longestPalindrome = palindrome.Length > longestPalindrome.Length ? palindrome : longestPalindrome;
        //                    }
        //                }
        //            }
        //            if (i - j >= 0)
        //            {
        //                palindrome = s[i - j].ToString() + palindrome;
        //                if (!palindromeDictionary.ContainsKey(palindrome))
        //                {
        //                    if (IsPalindrome(palindrome))
        //                    {
        //                        palindromeDictionary.Add(palindrome, true);
        //                        longestPalindrome = palindrome.Length > longestPalindrome.Length ? palindrome : longestPalindrome;
        //                    }
        //                }
        //            }
        //        }

        //    }
        //    return longestPalindrome;
        //}
    }
}
