function ListNode(val, next) {
    this.val = (val===undefined ? 0 : val)
    this.next = (next===undefined ? null : next)
}

/**
 * @param {ListNode} list1  
 * @param {ListNode} list2
 * @return {ListNode}
 */
var mergeTwoLists = function(list1, list2) {
    let l1curr = list1
    let l2curr = list2
    let head
    if (!l1curr) return list2
    if (!l2curr) return list1
    if (l1curr.val <= l2curr.val){
        head = l1curr
        l1curr = l1curr.next
    } else {
        head = l2curr
        l2curr = l2curr.next
    }
    let outcurr = head
    while (l1curr || l2curr){
        if (!l1curr){
            outcurr.next = l2curr
            l2curr = l2curr.next
        } else if (!l2curr){
            outcurr.next = l1curr
            l1curr = l1curr.next
        } else if (l1curr.val <= l2curr.val){
            outcurr.next = l1curr
            l1curr = l1curr.next
        } else {
            outcurr.next = l2curr
            l2curr = l2curr.next
        }
        outcurr = outcurr.next
    }
    return head
};

mergeTwoLists([1,2,4], [1,3,4])

