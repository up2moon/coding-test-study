public class Solution 
{
    public int RemoveDuplicates(int[] nums)
    {
        if(nums.Length == 1)
            return 1;

        int idx = 0;

        for(int i = 1; i < nums.Length; ++i)
        {
            if(nums[idx] != nums[i])
                nums[++idx] = nums[i];
        }
        return idx + 1;
    }
}