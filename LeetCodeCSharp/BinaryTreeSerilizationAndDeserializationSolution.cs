using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class BinaryTreeSerilizationAndDeserializationSolution
    {
        public string rserialize(TreeNode root, String str)
        {
            // Recursive serialization.
            if (root == null)
            {
                str += "null,";
            }
            else
            {
                str += root.val.ToString() + ",";
                str = rserialize(root.left, str);
                str = rserialize(root.right, str);
            }
            return str;
        }

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            return rserialize(root, "");
        }

        public TreeNode rdeserialize(List<string> l)
        {
            // Recursive deserialization.
            if (l[0] == "null")
            {
                l.RemoveAt(0);
                return null;
            }

            Console.WriteLine(l[0]);

            TreeNode root = new TreeNode(int.Parse(l[0]));
            l.RemoveAt(0);
            root.left = rdeserialize(l);
            root.right = rdeserialize(l);

            return root;
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(String data)
        {
            var data_array = data.Split(',');
            return rdeserialize(data_array.ToList());
        }
    }
}
