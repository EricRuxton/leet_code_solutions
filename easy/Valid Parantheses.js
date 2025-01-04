/**
 * @param {string} s
 * @return {boolean}
 */
var isValid = function (s) {
	let pairs = {
		')': '(',
		']': '[',
		'}': '{',
	};

	let stack = [];

	for (let i = 0; i < s.length; i++) {
		if (Object.values(pairs).includes(s[i])) {
			stack.push(s[i]);
		}
		if (Object.keys(pairs).includes(s[i])) {
			if (stack[stack.length - 1] === pairs[s[i]]) {
				stack.pop();
			} else {
				return false;
			}
		}
	}
	if (stack.length) return false;
	return true;
};

isValid('[');
