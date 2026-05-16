public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> list = new List<List<int>>();

        Array.Sort(nums);

        int i = 0, l = 0, r = 0;

        while (i < nums.Length) {
            if (nums[i] > 0)
                break;

            if (i > 0 && nums[i] == nums[i - 1]) {
                i++;
                continue;
            }
            l = i + 1;
            r = nums.Length - 1;
            while (l < r) {
                if (nums[i] + nums[l] + nums[r] == 0) {
                    list.Add(new List<int> { nums[i], nums[l], nums[r] });

                    l++;
                    r--;
                    while (l < r && nums[l] == nums[l - 1]) {
                        l++;
                    }
                    while (l < r && nums[r] == nums[r + 1]) {
                        r--;
                    }
                } else if (nums[i] + nums[l] + nums[r] > 0) {
                    r--;
                } else {
                    l++;
                }
            }
            i++;
        }
        return list;
    }
}
