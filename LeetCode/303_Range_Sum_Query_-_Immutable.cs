public class NumArray 
{
    private int[] PreSum { get; }

    public NumArray(int[] nums) 
    {
        PreSum = nums;
        for(int i = 1; i < PreSum.Length; ++i)
            PreSum[i] += PreSum[i - 1];  
    }
    
    public int SumRange(int left, int right) 
    {
        if(left == 0)
            return PreSum[right];
        return PreSum[right] - PreSum[left - 1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */