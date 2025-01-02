let x = 10;

/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function (x) {
	if (x < 0) return false;

	let reverse = '';
	for (let i = x.toString().length - 1; i >= 0; i--) {
		reverse += x.toString()[i];
	}
	return x == reverse;
};

isPalindrome(x);
