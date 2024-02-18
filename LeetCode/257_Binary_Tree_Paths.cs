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
    IList<string> List { get; } = new List<string>();

    public void Dfs(TreeNode node, StringBuilder sb)
    {
        if (node == null)
            return;
        int toDelete = 0;
        if (sb.Length > 0)
        {
            sb.Append("->");
            toDelete += 2;
        }
        var str = node.val.ToString();
        sb.Append(str);
        toDelete += str.Length;

        if (node.left == null && node.right == null)
            List.Add(sb.ToString());
        else
        {
            Dfs(node.left, sb);
            Dfs(node.right, sb);
        }
        int end = sb.Length;
        sb.Remove(end - toDelete, toDelete);
    }
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        Dfs(root, new StringBuilder());
        return List;
    }
}