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
    public bool Visit(TreeNode node, TreeNode node2)
    {
        if (node == null && node2 == null)
            return true;
        if (node != null && node2 == null || node == null && node2 != null)
            return false;
        if (!Visit(node.left, node2.left))
            return false;
        if (node.val != node2.val)
            return false;
        if (!Visit(node.right, node2.right))
            return false;
        return true;
    }
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        return Visit(p, q);
    }
}