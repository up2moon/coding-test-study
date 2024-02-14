public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        var list = new List<char>();
        var list2 = new List<char>();
        var sb = new StringBuilder();
        var sb2 = new StringBuilder();

        for (int i = 0; i < s.Length; ++i)
        {
            var idx = list.IndexOf(s[i]);
            if (idx == -1)
            {
                idx = list.Count;
                list.Add(s[i]);
            }
            sb.Append('A' + idx);
        }
        for (int i = 0; i < t.Length; ++i)
        {
            var idx = list2.IndexOf(t[i]);
            if (idx == -1)
            {
                idx = list2.Count;
                list2.Add(t[i]);
            }
            sb2.Append('A' + idx);
        }
        return sb.ToString() == sb2.ToString();
    }
}