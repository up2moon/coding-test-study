public class Solution
{
    public void ReverseString(char[] s)
    {
        int len = s.Length;
        for (int i = 0; i < len / 2; ++i)
        {
            char temp = s[i];
            s[i] = s[len - 1 - i];
            s[len - 1 - i] = temp;
        }
    }
}