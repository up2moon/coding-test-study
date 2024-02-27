public class Solution
{
    public int[] CountBits(int n)
    {
        int[] ans = new int[n + 1];

        ans[0] = 0;
        if (n == 0)
            return ans;
        ans[1] = 1;

        int idx = 0;

        for (int i = 2; i < ans.Length; ++i)
        {
            if ((i & (i - 1)) == 0)
                idx = 0;
            ans[i] = 1 + ans[idx++];
        }
        return ans;
    }
}