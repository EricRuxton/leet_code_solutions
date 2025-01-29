/**
 * @param {number} num1
 * @param {number} num2
 * @return {number}
 */
var minimizeXor = function(num1, num2) {
    let bitCount = num2.toString(2).replace(/0/g,"").length
    let binary = num1.toString(2).padStart(bitCount, 0)
    let outBinary = ''
    for (let i = 0; i < binary.length; i++){
        if (bitCount >= binary.length - i){
            outBinary += '1'
        } else {
            if (binary[i] == 1 && bitCount > 0){
                outBinary += '1'
                bitCount--
            } else {
                outBinary += '0'
            }
        }
    }
    return parseInt(outBinary, 2)
};

minimizeXor(1, 12)