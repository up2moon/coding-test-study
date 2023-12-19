
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public TreeNode CreateNode(int[] nums, int start, int end)
    {
        if (start > end)
            return null;
        var mid = (start + end) / 2;
        var num = nums[mid];
        var node = new TreeNode(num);

        node.left = CreateNode(nums, start, mid - 1);
        node.right = CreateNode(nums, mid + 1, end);

        return node;
    }
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return CreateNode(nums, 0, nums.Length - 1);
    }
}