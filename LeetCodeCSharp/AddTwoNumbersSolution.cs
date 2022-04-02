using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// You are given two non-empty linked lists representing two non-negative integers. 
/// The digits are stored in reverse order, and each of their nodes contains a single digit. 
/// Add the two numbers and return the sum as a linked list. 
/// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
/// 
/// Input: l1 = [2,4,3], l2 = [5,6,4]
/// 
/// Output: [7,0,8]
/// 
/// Explanation: 342 + 465 = 807.
/// 
/// 
/// Time complexity: O(max(m,n)) where m and n represents the length of l1 and l2 respectivley.
/// Space complexity: O(max(m, n)). 
/// </summary>

namespace LeetCodeCSharp
{
    public class AddTwoLinkedListsSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int sum = 0;
            var current = new ListNode(0);
            var result = current;

            //loop through both - use or so it does not matter if 
            while (l1 != null || l2 != null)
            {

                // if there is a node in l1 add the value to the sum
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                // if there is a node in l2 add the value to the sum 11 + l2
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                // put the remainder in the next node
                current.next = new ListNode(sum % 10);
                current = current.next;

                // if there is a carry over reset the sum value to 1 or 0
                sum = sum > 9 ? 1 : 0;

            }

            // if there is a 1 carry over, put it in the next node
            if (sum == 1) current.next = new ListNode(sum);

            //return result.next as the first result node is 0.
            return result.next;

        }
    }
}
