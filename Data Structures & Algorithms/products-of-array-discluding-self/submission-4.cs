public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] preArr = new int[nums.Length];
        preArr[0] = 1;
        int[] sufArr = new int[nums.Length];
        sufArr[nums.Length - 1] = 1;
        int[] retArr = new int[nums.Length];

        for (int i = 1; i < preArr.Length; i++) {
            preArr[i] = preArr[i - 1] * nums[i - 1];  //(1*1)(1*2)(2*4)
        }
        for (int i = sufArr.Length - 2; i > -1; i--) {
            sufArr[i] = sufArr[i + 1] * nums[i + 1];  //(1x6)(6x4)(24x2)
        }

        for (int i = 0; i < preArr.Length; i++) {
            retArr[i] = preArr[i] * sufArr[i];
        }
        return retArr;
    }
}