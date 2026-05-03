public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int prod = 1;
        int zeroCount = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                prod *= nums[i];
            } else {
                zeroCount++;
            }
        }

        int[] numsRet = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            if (zeroCount == 1) {
                if (nums[i] == 0) {
                    numsRet[i] = prod;
                } else {
                    numsRet[i] = 0;
                }
            } else if (zeroCount >= 2) {
                numsRet[i] = 0;
            } else {
                numsRet[i] = prod / nums[i];
            }
        }
        return numsRet;
    }
}