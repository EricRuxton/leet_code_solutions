var getNextUgly = function(lastUgly, twos, threes, fives) {
    if (twos[0] <= threes[0] && twos[0] <= fives[0]){
        if (twos[0] > lastUgly){
            return twos.shift()
        } 
        twos.shift()
    }
    if (threes[0] <= twos[0] && threes[0] <= fives[0]){
        if (threes[0] > lastUgly){
            return threes.shift()
        } 
        threes.shift()
    }
    if (fives[0] <= twos[0] && fives[0] <= threes[0]){
        if (fives[0] > lastUgly){
            return fives.shift()
        } 
        fives.shift()
    }
    return getNextUgly(lastUgly, twos, threes, fives)
}

/**
 * @param {number} n
 * @return {number}
 */
var nthUglyNumber = function(n) {
    let uglies = [1]
    let twos = []
    let threes = []
    let fives = []
    while (uglies.length < n) {
        twos.push(lastUgly*2); threes.push(lastUgly*3); fives.push(lastUgly*5)
        uglies.push(getNextUgly(uglies[uglies.length - 1], twos, threes, fives))
    }
    return uglies[uglies.length - 1]
};

nthUglyNumber(10)