using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given head, the head of a linked list, determine if the linked list has a cycle in it.
/// </summary>
namespace LeetCodeCSharp
{
    public class LinkedListCycleSolution
    {
        public bool hasCycle(ListNode head)
        {
            HashSet<ListNode> visited = new HashSet<ListNode>();

            while (head != null)
            {
                if (visited.Contains(head)) return true;
                visited.Add(head);
                head = head.next;
            }

            return false;
        }

        /// <summary>
        /// Floyd's Cycle Finding Algorithm - O(1) space complexity,
        /// </summary>
        /// <param name="head">Node</param>
        /// <returns>boolean</returns>
        public bool hasCycleFloydsCycleFindingAlgorithm(ListNode head)
        {
            if (head == null) return false;

            ListNode slow = head;

            ListNode fast = head.next;

            while (slow != fast)
            {
                if (fast == null || fast.next == null) return false;
                slow = slow.next;
                fast = fast.next.next;
            }

            return true;
        }
    }
}
