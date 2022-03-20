using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given a binary tree root, 
/// a node X in the tree is named good if in the path from root to X 
/// there are no nodes with a value greater than X.
/// Return the number of good nodes in the binary tree.
/// </summary>

namespace LeetCodeCSharp
{

    public class CountGoodNodesSolution
    {


        public int GoodNodes(TreeNode root)
        {
            return countGoodNodes(root, root.val);
        }


        private int countGoodNodes(TreeNode node, int maxSoFar)
        {
            int numOfGoodNodes = 0;

            if (node != null)
            {
                if (node.val >= maxSoFar)
                {
                    maxSoFar = node.val;
                    numOfGoodNodes++;
                }

                numOfGoodNodes += countGoodNodes(node.left, maxSoFar);
                numOfGoodNodes += countGoodNodes(node.right, maxSoFar);
            }

            return numOfGoodNodes;
        }

        // time complexit = O(n)
        // space complixity = O(n)
    }
}
