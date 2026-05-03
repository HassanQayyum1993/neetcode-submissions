public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] numsRet = new int[nums.Length];
        Array.Fill(numsRet, 1);
        for (int i = 0; i < nums.Length; i++) {
            for (int j = 0; j < nums.Length; j++) {
                if (i != j) {
                    numsRet[i] *= nums[j];
                }
            }
        }
        return numsRet;
    }
}
