public class Solution 
{
    public int LengthOfLastWord(string s) 
    {
        s = s.TrimEnd();
        return s.Split(' ').Last().Length;
    }
}