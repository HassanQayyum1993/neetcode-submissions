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
        var ndict = dict.OrderByDescending(x => x.Value);
        int[] n = new int[k];
        int count = 0;
        foreach (var item in ndict) {
            if (count == k) {
                break;
            }
            n[count] = item.Key;
            count++;
        }
        return n;
    }
}
