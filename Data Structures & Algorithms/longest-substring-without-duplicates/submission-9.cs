public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length < 2) {
            return s.Length;
        }

        int r = 1, l = 0, count = 1, max = 0;
        HashSet<char> h = new HashSet<char>();
        h.Add(s[l]);
        while (r < s.Length) {
            if (!h.Contains(s[r])) {
                h.Add(s[r]);
                r++;
                count++;
            } else {
                h = new HashSet<char>();
                l++;
                h.Add(s[l]);
                r = l + 1;
                if (max < count) {
                    max = count;
                }
                count = 1;
            }
        }
        if (max < count) {
            max = count;
        }
        return max;
    }
}
