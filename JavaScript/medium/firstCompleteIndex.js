/**
 * @param {number[]} arr
 * @param {number[][]} mat
 * @return {number}
 */

// Preprocess the 2D array into a hash map
const preprocessArray = (array) => {
    const map = new Map();
    for (let i = 0; i < array.length; i++) {
      for (let j = 0; j < array[i].length; j++) {
          map.set(array[i][j], [i, j]);
      }
    }
    return map;
  };
  
  
var firstCompleteIndex = function(arr, mat) {
      let xLength = mat[0].length
      let yLength = mat.length
      let xArray = new Array(xLength).fill(0)
      let yArray = new Array(yLength).fill(0)
      let map = preprocessArray(mat)
      for (let i = 0; i < arr.length; i++){
          let [x, y] = map.get(arr[i]);
          xArray[x]++
          yArray[y]++
          if (xArray[x] == yLength || yArray[y] == xLength) {console.log(i); return i}
      }
  };

firstCompleteIndex([2,8,7,4,1,3,5,6,9], [[3,2,5],[1,4,6],[8,7,9]])