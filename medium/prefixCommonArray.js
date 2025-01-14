/**
 * @param {number[]} A
 * @param {number[]} B
 * @return {number[]}
 */
var findThePrefixCommonArray = function(A, B) {
    let holder = {}
    let collisionArray = []
    let collisions = 0;
    for (let i = 0; i < A.length; i++){
        if (holder[A[i]]){
            collisions++
        } else {
            holder[A[i]] = true
        }
        if (holder[B[i]]){
            collisions++
        } else {
            holder[B[i]] = true
        }
        collisionArray[i] = collisions
    }    
    return collisionArray
};

findThePrefixCommonArray([1,3,2,4], [3,1,2,4])