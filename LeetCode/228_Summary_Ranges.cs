public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        IList<string> list = new List<string>();
        int startIdx = -1;
        int endIdx = -1;

        if (nums.Length == 1)
            list.Add(nums[0].ToString());
        if (nums.Length < 2)
            return list;

        for (int i = 0; i < nums.Length - 1; ++i)
        {
            if (startIdx == -1)
                startIdx = i;
            if (nums[i] + 1 != nums[i + 1])
                endIdx = i;
            else if (i + 1 == nums.Length - 1)
                endIdx = i + 1;
            if (startIdx != -1 && endIdx != -1)
            {
                if (endIdx - startIdx > 0)
                    list.Add($"{nums[startIdx]}->{nums[endIdx]}");
                else
                    list.Add(nums[startIdx].ToString());
                if (endIdx != i + 1 && i + 1 == nums.Length - 1)
                    list.Add(nums[i + 1].ToString());
                startIdx = -1;
                endIdx = -1;
            }
        }
        return list;
    }
}