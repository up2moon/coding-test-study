public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        return (n & (n - 1)) == 0 && (n - 1) % 3 == 0;
    }
}