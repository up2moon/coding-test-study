public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; ++i)
        {
            if (dict.Count <= k)
            {
                if (dict.ContainsKey(nums[i]))
                    return true;
                dict[nums[i]] = 1;
            }
            if (dict.Count == k + 1)
                dict.Remove(nums[i - k]);
        }
        return false;
    }
}