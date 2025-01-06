/**
 * @param {number[]} nums
 * @return {number}
 */
var removeDuplicates = function(nums) {
    let seen = {}
    let duplicates = 0
    for (let i = 0; i < nums.length; i++){
        let num = nums[i]
        if (!seen[num]){
            nums[i-duplicates] = num
            seen[num] = true
        } else {
            duplicates++
        }
        console.log(nums)
    }
    return nums.length - duplicates
};

removeDuplicates([0,0,1,1,1,2,2,3,3,4])