/**
 * @param {number[]} nums
 * @param {number} val
 * @return {number}
 */
var removeElement = function(nums, val) {
    let found = 0;
    for (let i = 0; i < nums.length; i++){
        if (nums[i] !== val){
            let temp = nums[i]
            nums[i] = ''
            nums[i-found] = temp
        } else {
            found++
        }
    }
    return nums.length - found
};

removeElement([0,1,2,2,3,0,4,2], 2)