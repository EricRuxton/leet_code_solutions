/**
 * @param {number} n
 * @return {number}
 */
var steps = function (n, memo = {}){
    if (n == 1 || n == 0) return 1
    if (memo[n]) return memo[n];
    return memo[n] = steps(n - 1, memo) + steps(n - 2, memo);
}


var climbStairs = function(n) {
    if (n == 1) return 1
    console.log(steps(n-1) + steps (n-2))
};

climbStairs(5)