/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function(s) {
    let longestString = ''
    longestLength = 0
    for (let i = 0; i < s.length; i++){
        if (longestString.includes(s[i])){
            longestString = longestString.split(s[i])[1]
        }
        longestString += s[i]
        if (longestString.length > longestLength) longestLength = longestString.length
    }
    return longestLength
};

lengthOfLongestSubstring('abcabcbb')