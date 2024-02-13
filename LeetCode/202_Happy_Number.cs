public class Solution
{
    public bool IsHappy(int n)
    {
        int count = 0;

        while (true)
        {
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            if (++count == 10)
                return false;
            if (sum == 1)
                return true;
            n = sum;
            sum = 0;
        }
    }
}