using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    internal class InorderTraversalSolution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            InOrder(root, res);
            return res;
        }

        public void InOrder(TreeNode root, List<int> res)
        {
            if (root != null)
            {
                InOrder(root.left, res);
                res.Add(root.val);
                InOrder(root.right, res);
            }
            
        }
    }
}
