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
    private Stack<TreeNode> Stack { get; } = new Stack<TreeNode>();

    public bool Dfs(TreeNode node, int targetSum)
    {
        if (node == null)
        {
            Stack.Push(new TreeNode());
            return false;
        }
        Stack.Push(node);

        if (node.left == null && node.right == null)
            return Stack.Sum(n => n.val) == targetSum;
        if (Dfs(node.left, targetSum))
            return true;
        Stack.TryPop(out _);
        if (Dfs(node.right, targetSum))
            return true;
        Stack.TryPop(out _);
        return false;
    }

    public bool HasPathSum(TreeNode root, int targetSum)
    {
        return Dfs(root, targetSum);
    }
}