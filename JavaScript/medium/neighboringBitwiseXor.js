/**
 * @param {number[]} derived
 * @return {boolean}
 */
var doesValidArrayExist = function(derived) {
    let out = derived[0] == 1 ? false : true
    for (let i = 1; i < derived.length; ++i){
        if (derived[i] == 1){
            out = !out
        }
    }
    return out
};

doesValidArrayExist([1,1,0])