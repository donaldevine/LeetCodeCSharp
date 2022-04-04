using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given the root of a binary tree, determine if it is a valid binary search tree (BST).
/// 
/// A valid BST is defined as follows:
/// 
/// The left subtree of a node contains only nodes with keys less than the node's key.
/// The right subtree of a node contains only nodes with keys greater than the node's key.
/// Both the left and right subtrees must also be binary search trees.
/// 
/// Input: root = [2,1,3]
/// 
/// Output: true
/// 
/// 
/// Input: root = [5,1,4,null,null,3,6]
/// 
/// Output: false
/// Explanation: The root node 's value is 5 but its right child's value is 4.
/// </summary>

namespace LeetCodeCSharp
{
    public class ValidateBinarySearchTreeSolution
    {

        // Depth First Search
        // Time Complexity: O(N)
        // Space Complexity: O(N) - regression stack will hold all nodes in a skewed BST.

        public bool IsValidBST(TreeNode root)
        {
            return Validate(root, null, null);
        }

        private bool Validate(TreeNode root, int? min, int? max)
        {
            if (root == null) return true;

            if ((max != null && root.val >= max.Value) || (min != null && root.val <= min.Value)) return false;

            return (Validate(root.left, min, root.val) && Validate(root.right, root.val, max));
        }


        // In Order
        // Time Complexity: O(N)
        // Space Complexity: O(N)

        private int? prev;

        public bool IsValidBSTInOrder(TreeNode root)
        {
            prev = null;
            return InOrder(root);
        }

        private bool InOrder(TreeNode root)
        {
            if(root == null) return true;
            if (!InOrder(root.left)) return false;
            if (prev != null && root.val <= prev.Value) return false;
            prev = root.val;
            return InOrder(root.right);
        }
    }
}
