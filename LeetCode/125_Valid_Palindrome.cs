public class Solution
{
    public bool IsPalindrome(string s)
    {
        var sb = new StringBuilder();

        for (int i = 0; i < s.Length; ++i)
        {
            if (char.IsAsciiLetterOrDigit(s[i]))
                sb.Append(char.ToLower(s[i]));
        }

        s = sb.ToString();

        return s == new string(s.Reverse().ToArray());
    }
}