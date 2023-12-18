public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        if ((s.Length & 1) == 1)
            return false;
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                stack.Push(s[i]);
                continue;
            }
            if (s[i] == ')' || s[i] == ']' || s[i] == '}')
            {
                if (stack.Count == 0)
                    return false;
                var ch = stack.Pop();

                if (ch == '(' && s[i] != ')' || ch == '[' && s[i] != ']' || ch == '{' && s[i] != '}')
                    return false;
            }
        }
        if (stack.Count > 0)
            return false;
        return true;
    }
}