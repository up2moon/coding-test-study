public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int idx = m - 1, idx2 = n - 1;

        for (int i = m + n - 1; i >= 0; --i)
        {
            if (idx >= 0 && idx2 >= 0)
            {
                if (nums1[idx] > nums2[idx2])
                    nums1[i] = nums1[idx--];
                else
                    nums1[i] = nums2[idx2--];
            }
            else
            {
                if (idx2 < 0)
                    nums1[i] = nums1[idx--];
                else
                    nums1[i] = nums2[idx2--];
            }
        }
    }
}