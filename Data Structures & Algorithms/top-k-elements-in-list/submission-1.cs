public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (dict.ContainsKey(nums[i])) {
                dict[nums[i]]++;
            } else {
                dict[nums[i]] = 1;
            }
        }
        int[][] arr = dict.Select(x => new int[] { x.Key, x.Value }).ToArray();
        Array.Sort(arr, (a, b) => b[1].CompareTo(a[1]));

        int[] retArr = new int[k];

        for (int i = 0; i < k; i++) {
            retArr[i] = arr[i][0];
        }
        return retArr;
    }
}
