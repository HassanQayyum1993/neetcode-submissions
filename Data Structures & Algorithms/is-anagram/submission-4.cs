public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> sDict = new Dictionary<char, int>();
        Dictionary<char, int> tDict = new Dictionary<char, int>();

        foreach (var item in s)
        {
            if (sDict.ContainsKey(item))
            {
                sDict[item]++;
            }
            else
            {
                sDict[item] = 1;
            }
        }

        foreach (var item in t)
        {
            if (tDict.ContainsKey(item))
            {
                tDict[item]++;
            }
            else
            {
                tDict[item] = 1;
            }
        }

        foreach (var item in sDict)
        {
            if (!tDict.ContainsKey(item.Key))
            {
                return false;
            }

            if (sDict[item.Key] != tDict[item.Key])
            {
                return false;
            }
        }

        return true;
    }
}
