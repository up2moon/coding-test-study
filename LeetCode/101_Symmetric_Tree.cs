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
    public List<int> list = new List<int>();

    public void Visit(TreeNode node, int level)
    {
        if (node == null)
            return;
        Visit(node.left, level + 1);
        list.Add(node.val | (1 << (8 + level)));
        Visit(node.right, level + 1);
    }

    public bool IsSymmetric(TreeNode root)
    {
        Visit(root, 0);
        if ((list.Count & 1) == 0)
            return false;
        var n = list.Count;
        for (int i = 0; i < n / 2; ++i)
        {
            if (list[i] != list[n - 1 - i])
                return false;
        }
        return true;
    }
}