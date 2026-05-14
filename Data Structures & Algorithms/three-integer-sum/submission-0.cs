public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> retL = new List<List<int>>();
        HashSet<Tuple<int, int, int>> h = new HashSet<Tuple<int, int, int>>();

        Array.Sort(nums, (a, b) => a.CompareTo(b));

        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                for (int k = j + 1; k < nums.Length; k++) {
                    if (nums[i] + nums[j] + nums[k] == 0) {
                        var tuple = new Tuple<int, int, int>(nums[i], nums[j], nums[k]);

                        if (h.Contains(tuple)) {
                            continue;
                        }
                        retL.Add(new List<int>() { nums[i], nums[j], nums[k] });
                        h.Add(Tuple.Create(nums[i], nums[j], nums[k]));
                    }
                }
            }
        }
        return retL;
    }
}
