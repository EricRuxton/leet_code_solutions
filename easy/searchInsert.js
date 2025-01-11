var getMid = function(lo, hi){
    return Math.floor((lo+hi)/2)
}

var walk = function (nums, target, lo, hi){
    let mid = getMid(lo, hi, nums)
    let val = nums[mid]

    if (val === target || target < val && target > nums[mid - 1]) return mid

    if (val > target){
        return walk(nums, target, lo, mid - 1)
    }
    else {
        return walk(nums, target, mid + 1, hi)
    }
}

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
//MUST HAVE O(logn) TIME COMPLEXITY
var searchInsert = function(nums, target) {
    if (target > nums[nums.length-1]) return nums.length
    if (target <= nums[0]) return 0
    return walk(nums, target, 0, nums.length-1)
};

searchInsert([1,3], 2)