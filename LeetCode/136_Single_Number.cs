public class Solution
{
    public int SingleNumber(int[] nums)
    {
        Array.Sort(nums);
        int n = nums.Length & ~1;
        for (int i = 0; i < n; i += 2)
        {
            if (nums[i] != nums[i + 1])
                return nums[i];
        }
        return nums[nums.Length - 1];
    }
}