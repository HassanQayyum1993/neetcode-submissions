public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        char[] c1 = s.ToCharArray();
        char[] c2 = t.ToCharArray();

        Array.Sort(c1);
        Array.Sort(c2);

        for (int i = 0; i < c1.Length; i++)
        {
            if (c1[i] != c2[i])
            {
                return false;
            }
        }

        return true;
    }
}
