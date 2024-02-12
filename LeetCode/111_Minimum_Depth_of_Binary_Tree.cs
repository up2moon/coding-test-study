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
    private Queue<(TreeNode, int)> Queue { get; } = new Queue<(TreeNode, int)>();

    public int Bfs(TreeNode node)
    {
        Queue.Enqueue((node, 1));

        int depth;

        while (true)
        {
            if (!Queue.TryDequeue(out var tuple))
                return 0;
            (node, depth) = tuple;
            if (node == null)
                return 0;

            if (node.left == null && node.right == null)
                return depth;

            if (node.left != null)
                Queue.Enqueue((node.left, depth + 1));
            if (node.right != null)
                Queue.Enqueue((node.right, depth + 1));
        }
        return 0;
    }
    public int MinDepth(TreeNode root)
    {
        return Bfs(root);
    }
}