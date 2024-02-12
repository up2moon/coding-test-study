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
    private IList<int> List { get; } = new List<int>();

    public void Visit(TreeNode node)
    {
        if (node == null)
            return;
        List.Add(node.val);
        Visit(node.left);
        Visit(node.right);
    }

    public IList<int> PreorderTraversal(TreeNode root)
    {
        Visit(root);
        return List;
    }
}