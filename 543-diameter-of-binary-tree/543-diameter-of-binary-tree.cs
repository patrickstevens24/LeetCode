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
public class Solution {
    public int max = 0;
    
    public int DiameterOfBinaryTree(TreeNode root) {
        CalcHeight(root);
        return max;
    }
    
    public int CalcHeight(TreeNode root) {
        if (root == null) {
            return -1;
        }
        
        int left = CalcHeight(root.left);
        int right = CalcHeight(root.right);
        
        max = Math.Max(max, 2 + left + right);
        
        return (1 + Math.Max(left, right));
    }
}