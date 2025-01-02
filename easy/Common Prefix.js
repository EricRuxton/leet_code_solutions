let strs = [''];

/**
 * @param {string[]} strs
 * @return {string}
 */
var longestCommonPrefix = function (strs) {
	let values = strs.sort();

	let first = values[0];
	let last = values[strs.length - 1];

	let common = '';

	for (let i = 0; i < first.length; i++) {
		if (first[i] !== last[i]) break;
		common += first[i];
	}
	return common;
};

longestCommonPrefix(strs);
