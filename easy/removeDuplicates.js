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
    }
    return nums.length - duplicates
};

removeDuplicates([0,0,1,1,1,2,2,3,3,4])


//Better implementation
// if (nums.length === 0) {
//     return 0;
// }

// let k = 1; // Initialize the count of unique elements to 1
// for (let i = 1; i < nums.length; i++) {
//     if (nums[i] !== nums[k - 1]) {
//         nums[k] = nums[i]; // Overwrite the next unique element
//         k++;
//     }
// }

// return k;