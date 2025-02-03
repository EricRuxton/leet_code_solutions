namespace Leetcode.medium
{
    internal class SwapPairs
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
                        next = null
                    }
                }
            }
        };

        public ListNode Run(ListNode? head)
        {
            int index = 0;
            ListNode temp;
            ListNode? previous = null;
            ListNode? tempNext = head;
            ListNode? current = head;
            while (current?.next != null)
            {
                Console.WriteLine(current.next);
                if (index == 0)
                {
                    temp = current;
                    current = current.next;
                    tempNext = current.next;
                    current.next = temp;
                    current.next.next = tempNext;
                    if (previous != null) previous.next = current;
                    index = 1;
                    if (temp == head)
                    {
                        head = current;
                    }
                    previous = current;
                    current = current.next;
                }
                else
                {
                    previous = current;
                    current = current.next;
                    index = 0;
                }
            }
            return head;
        }
    }
}
