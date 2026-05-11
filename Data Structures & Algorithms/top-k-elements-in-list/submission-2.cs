public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> d = new Dictionary<int, int>();

        foreach (var i in nums) {
            if (d.ContainsKey(i)) {
                d[i]++;
            } else {
                d[i] = 1;
            }
        }
        PriorityQueue<int, int> p = new PriorityQueue<int, int>();

        foreach (var i in d) {
            p.Enqueue(i.Key, -i.Value);
        }

        int[] retArr = new int[k];
        for (int i = 0; i < k; i++) {
            retArr[i] = p.Dequeue();
        }
        return retArr;
    }
}
