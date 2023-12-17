public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
        string s = "";
        char currentCharacter;
        int idx = 0;

        if(strs.Length == 1)
            return strs[0];
        do
        {
            if(strs[0].Length <= idx)
                return s;
            currentCharacter = strs[0][idx];
            
            for(int i = 1; i < strs.Length; ++i)
            {
                if(strs[i].Length <= idx || strs[i][idx] != currentCharacter)
                    return s;
            }
            ++idx;
            s += currentCharacter;

        }while(true);
        return s;
    }
}