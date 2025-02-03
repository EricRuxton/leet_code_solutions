namespace Leetcode.easy
{
    internal class DeleteDuplicates
    {
        public class ListNode
        {
            public int val;
            public ListNode? next;
            public ListNode(int val = 0, ListNode? next = null)
            {
                this.val = val;
                this.next = next;
            }
        };

        public ListNode _head = new()
        {
            val = 1,
            next = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 2,
                    next = new ListNode()
                    {
                        val = 3,
                        next = new ListNode()
                        {
                            val = 4,
                            next = new ListNode()
                            {
                                val = 4,
                                next = null
                            }
                        }
                    }
                }
            }
        };

        public ListNode Run(ListNode head)
        {
            if (head == null) return head;
            ListNode current = head;
            while (current.next != null)
            {
                if (current.next.val != current.val)
                {
                    current = current.next;
                }
                else
                {
                    current.next = current.next.next;
                }
            }
            return head;
        }
    }
}
