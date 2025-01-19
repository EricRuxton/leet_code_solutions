/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
l1 = {
    val: 9,
    next: {
        val: 9,
        next: {
            val: 9,
            next: {
                val: 9,
                next: {
                    val: 9,
                    next: {
                        val: 9,
                        next: {
                            val: 9,
                            next: null
                        }
                    }
                }
             }
        }
    }
}

l2 = {
    val: 9,
    next: {
        val: 9,
        next: {
            val: 9,
            next: {
                val: 9,
                next: null
            }
        },
    }
}
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
var addTwoNumbers = function(l1, l2) {
    let carry = 0
    let value = l1.val + l2.val
    if (value >= 10){
        value -= 10
        carry = 1
    }
    let head = {val: value, next: null}
    let focus = head
    let l1Curr = l1.next
    let l2Curr = l2.next
    while (l1Curr || l2Curr || carry){
        let value = (l1Curr ? l1Curr.val : 0) + (l2Curr ? l2Curr.val : 0) + carry
        if (value >= 10){
            value -= 10
            carry = 1
        } else {
            carry = 0
        }
        focus.next = {val: value, next: null}
        focus = focus.next
        l1Curr = l1Curr?.next || null
        l2Curr = l2Curr?.next || null
    }
    return head
};

addTwoNumbers(l1, l2)

/*    
    This would work if the given data was actually a linked list, and not an array.
    let l1Curr = l1
    let l2Curr = l2 
    let head = l1Curr
    let carry = 0
    while (l2Curr || carry){
        let value = (l1Curr.value ? l1Curr.value : 0) + (l2Curr ? l2Curr.value : 0) + carry
        if (value >= 10){
            l1Curr.value = value - 10
            carry = 1
        } else {
            l1Curr.value = value
            carry = 0
        }
        l2Curr = l2Curr?.next || null
        console.log(l1Curr.value)
        l1Curr = l1Curr.next ? l1Curr.next : { value: 0, next: null}
    }
    return head
*/