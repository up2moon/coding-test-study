public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        if (n <= 0)
            return false;
        while (n > 1)
        {
            if ((n & 1) == 1)
                return false;
            n >>= 1;
        }
        return true;
    }
}