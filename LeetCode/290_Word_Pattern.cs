public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var dict = new Dictionary<char, string>();
        var arr = s.Split(' ');

        if (pattern.Length != arr.Length)
            return false;
        for (int i = 0; i < arr.Length; ++i)
        {
            var word = arr[i];
            var ch = pattern[i];

            if (dict.ContainsKey(ch))
            {
                if (dict[ch] != word)
                    return false;
            }
            else
                dict[ch] = word;
        }

        return dict.Values.Count() == dict.Values.Distinct().Count();
    }
}