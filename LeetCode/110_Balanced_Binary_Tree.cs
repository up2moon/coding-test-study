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
    public int Visit(TreeNode node, int depth)
    {
        if (node == null)
            return depth - 1;

        int leftDepth = Visit(node.left, depth + 1);
        int rightDepth = Visit(node.right, depth + 1);

        if (Math.Abs(leftDepth - rightDepth) > 1)
            return -2;

        return Math.Max(leftDepth, rightDepth);
    }

    public bool IsBalanced(TreeNode root)
    {
        return Visit(root, 0) != -2;
    }
}