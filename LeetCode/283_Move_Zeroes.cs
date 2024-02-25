public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int idx = 0;

        for (int i = 1; i < nums.Length; ++i)
        {
            if (nums[idx] == 0)
            {
                if (nums[i] == 0)
                    continue;
                int temp = nums[idx];
                nums[idx] = nums[i];
                nums[i] = temp;
            }
            ++idx;
        }
    }
}