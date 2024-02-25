public class Solution
{
    public int MissingNumber(int[] nums)
    {
        return Enumerable.Range(0, nums.Length + 1).Except(nums).FirstOrDefault();
    }
}