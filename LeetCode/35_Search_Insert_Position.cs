public class Solution 
{
    public int SearchInsert(int[] nums, int target) 
    {
        var list = new List<int>(nums);
        var idx = list.BinarySearch(target);
        if(idx < 0)
            idx = ~idx;
        return idx;
    }
}