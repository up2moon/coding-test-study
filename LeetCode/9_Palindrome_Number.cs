public class Solution
{
    public bool IsPalindrome(int x)
    {
        var s = x.ToString();
        var n = s.Length;

        for (int i = 0; i < n / 2; ++i)
        {
            if (s[i] != s[n - 1 - i])
                return false;
        }
        return true;
    }
}