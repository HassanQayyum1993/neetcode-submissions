public class Solution {
    public bool IsPalindrome(string s) {
        List<char> arr = new List<char>();

        foreach (var c in s) {
            if (char.IsLetterOrDigit(c)) {
                arr.Add(c);
            }
        }
        int i = 0;
        int j = arr.Count - 1;

        while (i < arr.Count / 2) {
            if (char.ToLower(arr[i]) != char.ToLower(arr[j])) {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
