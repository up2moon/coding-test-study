public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        int num = 0;

        for (int i = 0; i < columnTitle.Length; ++i)
        {
            int n = columnTitle.Length - 1 - i;
            num += (int)Math.Pow(26, n) * (columnTitle[i] - 'A' + 1);
        }
        return num;
    }
}