public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        return nums.Length != new HashSet<int>(nums).Count;
    }
}