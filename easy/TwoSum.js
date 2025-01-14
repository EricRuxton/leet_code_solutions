var twoSum = function(nums, target) {
    let numsObj = {}
    for (let i = 0; i < nums.length; ++i ){
        if (numsObj[nums[i]] !== undefined && i !== numsObj[nums[i]])
            {
                return[i, numsObj[nums[i]]]
            }        
        numsObj[target - nums[i]] = i
    }
};

twoSum([5,5], 10)