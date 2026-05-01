public class Solution {
    public bool IsAnagram(string s, string t)
{
if(s.Length!=t.Length)
{
    return false;
}
    Dictionary<char, int> sdict = new Dictionary<char, int>();
    Dictionary<char, int> tdict = new Dictionary<char, int>();

    foreach (var item in s)
    {
        if (sdict.ContainsKey(item))
        {
            sdict[item]++;
        }
        else
        {
            sdict[item] = 1;
        }
    }
    foreach (var item in t)
    {
        if (tdict.ContainsKey(item))
        {
            tdict[item]++;
        }
        else
        {
            tdict[item] = 1;
        }
    }

    foreach (var item in sdict)
    {
        if (!tdict.ContainsKey(item.Key))
        {
            return false;
        }
        if (sdict[item.Key] != tdict[item.Key])
        {
            return false;
        }
    }
    return true;
}
}
