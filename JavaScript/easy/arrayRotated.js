var check = function(nums) {
    let tripped = false
    if (nums.length == 1) return true
    for (let i  = 0; i < nums.length; i++){
        let nextI = (i + 1) % nums.length
        if (nums[i] > nums[nextI]){
            if (tripped) return false
            tripped = true
        }
        
    }
    return true
};

check([2,1,3,4])