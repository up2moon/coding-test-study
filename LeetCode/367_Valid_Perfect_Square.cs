public class Solution
{
    private int BinarySearch(int num)
    {
        long left = 0;
        long right = num / 2;

        while (left <= right)
        {
            long mid = (left + right) / 2;
            long powered = mid * mid;

            if (powered == num)
                return (int)mid;
            if (powered > num)
                right = mid - 1;
            else
                left = mid + 1;
        }
        return -1;
    }

    public bool IsPerfectSquare(int num)
    {
        if (num == 1)
            return true;
        return BinarySearch(num) != -1;
    }
}