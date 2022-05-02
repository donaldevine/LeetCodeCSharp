using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Design an algorithm to serialize and deserialize a binary search tree. 
/// 
/// Time Complexity: O(N)
/// Space Complexity: O(N)
/// </summary>

namespace LeetCodeCSharp
{
    public class BSTTreeSerializationAndDeserializationSolution
    {

        public StringBuilder postorder(TreeNode root, StringBuilder sb)
        {
            if (root == null) return sb;
            postorder(root.left, sb);
            postorder(root.right, sb);
            sb.Append(root.val);
            sb.Append(' ');
            return sb;
        }

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            StringBuilder sb = postorder(root, new StringBuilder());
            if (sb.Length > 0) sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        public TreeNode helper(int lower, int upper, List<int> nums)
        {
            if (nums.Count == 0) return null;
            
            int val = nums.Last<int>();

            if (val < lower || val > upper) return null;

            nums.RemoveAt(nums.Count - 1);

            TreeNode root = new TreeNode(val);
            root.right = helper(val, upper, nums);
            root.left = helper(lower, val, nums);
            return root;
        }


        // Decodes your encoded data to tree.
        public TreeNode deserialize(String data)
        {
            if (String.IsNullOrEmpty(data)) return null;

            List<int> nums = new List<int>();

            var arrList = data.Split(' ');

            foreach (var s in arrList)
            {
                nums.Add(int.Parse(s));
            }
            
            return helper(int.MinValue, int.MaxValue, nums);
        }
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// String tree = ser.serialize(root);
// TreeNode ans = deser.deserialize(tree);
// return ans;