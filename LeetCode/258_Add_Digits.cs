public class Solution
{
    public int AddDigits(int num)
    {
        while (true)
        {
            int sum = 0;
            while (num > 0)
            {
                int val = num % 10;
                num /= 10;
                sum += val;
            }
            if (sum < 10)
                return sum;
            num = sum;
        }
        return 0;
    }
}