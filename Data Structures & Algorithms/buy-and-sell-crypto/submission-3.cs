public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        int l = 0, r = 1;
        while (r < prices.Length) {
            if (prices[l] < prices[r]) {
                if (max < prices[r] - prices[l]) {
                    max = prices[r] - prices[l];
                }
            } else {
                l = r;
            }
            r++;
        }
        return max;
    }
}
