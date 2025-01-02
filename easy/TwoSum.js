let nums = [5,5]
let target = 10

var twoSum = function(nums, target) {
    let numsObj = {}
    for (let i = 0; i < nums.length; ++i ){
        if (numsObj[nums[i]] !== undefined && i !==numsObj[nums[i]])
            {
                console.log([i, numsObj[nums[i]]])
                return[i, numsObj[nums[i]]]
            }        
        numsObj[target-nums[i]] = i
    }
};

twoSum(nums, target)