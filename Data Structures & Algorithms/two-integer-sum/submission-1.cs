public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> d = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (d.ContainsKey(complement)) {
                return new int[] { d[complement], i };
            }

            d[nums[i]] = i;
        }

        return new int[0];
    }
}