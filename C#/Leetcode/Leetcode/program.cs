using Leetcode.medium;

//TwoSum ts = new TwoSum();
//Console.WriteLine(string.Join(",", ts.Run([3, 3], 6)));

//SearchInsert si = new SearchInsert();
//Console.WriteLine(si.Run([1, 3, 5, 6], 7));

FindMaxFish fmf = new FindMaxFish();
int[][] array = [[0, 2, 1, 0], [4, 0, 0, 3], [1, 0, 0, 4], [0, 3, 2, 0]];
Console.WriteLine(fmf.Run(array));