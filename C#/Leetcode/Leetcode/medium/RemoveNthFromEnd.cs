namespace Leetcode.medium
{
    internal class RemoveNthFromEnd
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
        }

        public ListNode? _head = new()
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
                            val = 5,
                            next = null
                        }
                    }
                }
            }
        };

        public ListNode Run(ListNode head, int n)
        {
            int index = 0;
            ListNode? current = head;
            ListNode? offset = head;
            if (head?.next == null && n == 1) { head = null; return head; }

            while (current.next != null)
            {
                if (index >= n)
                    offset = offset.next;
                current = current?.next;


                index++;
            }
            if (index < n) return head.next;
            offset.next = offset?.next?.next ?? null;
            return head;
        }
    }
}
