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
    public int maxDepth = 0;

    public void Visit(TreeNode node, int depth)
    {
        if (node == null)
            return;
        Visit(node.left, depth + 1);
        if (depth > maxDepth)
            maxDepth = depth;
        Visit(node.right, depth + 1);
    }

    public int MaxDepth(TreeNode root)
    {
        Visit(root, 1);
        return maxDepth;
    }
}