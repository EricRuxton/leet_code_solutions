namespace Leetcode.medium
{
    internal class ReverseInteger
    {

        public int Run(int x)
        {
            bool isNeg = x < 0;
            var stringX = string.Join("", x.ToString().ToCharArray().Reverse());
            if (isNeg) stringX = "-" + stringX.Substring(0, stringX.Length - 1);
            if (Int32.TryParse(stringX, out int result)) return result;
            else return 0;
        }
    }
}
