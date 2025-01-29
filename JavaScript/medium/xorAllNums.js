/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number}
 */
var xorAllNums = function(nums1, nums2) {
    //XOR logic for arrays is unique.
    //If both arrays are of even length, each pair will appear twice in nums3 (nums1[y]^nums2[x] and nums2[y]^nums1[x])
    //this means each pair will cancel out resulting in 0
    if (nums1.length % 2 === 0 && nums2.length % 2 === 0){
        return 0
    }
    //If both arrays are odd, the resulting matrix will have an odd number of every pair, which after cancellation will leave exactly one of each pair
    else if (nums1.length % 2 === 1 && nums2.length % 2 === 1){
        let out = nums1[0]
        for (let i = 1; i < nums1.length; i++){
            out ^= nums1[i]
        }
        for (let i = 0; i < nums2.length; i++){
            out ^= nums2[i]
        }
        return out
    }
    //If one array is odd and one is even, all the values in the odd array, will appear an even amount of times, cancelling themselves out
    //this means we only need to xor the even array
    else {
        let evenArray = nums1.length % 2 == 0 ? nums1 : nums2
        let out = evenArray[0]
        for (let i = 1; i < evenArray.length; i++){
            out ^= evenArray[i]
        }
        return out
    }
};

xorAllNums([1,2], [3,4])