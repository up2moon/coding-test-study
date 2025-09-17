public class Solution
{
    public int ReverseBits(int n)
    {
        int result = 0;
        var list = new List<int>();

        while (n > 0)
        {
            int remainder = n & 1;
            list.Add(remainder);
            n >>= 1;
        }

        int count = list.Count;
        for (int i = 0; i < 32 - count; ++i)
            list.Add(0);
        count = list.Count;
        for (int i = 0; i < count; ++i)
        {
            int idx = count - 1 - i;
            result += (int)Math.Pow(2, i) * list[idx];
        }
        return result;
    }
}