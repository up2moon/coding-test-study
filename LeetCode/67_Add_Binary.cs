public class Solution 
{
    public string AddBinary(string a, string b) 
    {
        var stack = new Stack<char>();
        int carryBit = 0;
        int n = Math.Max(a.Length, b.Length);

        for(int i = 0; i < n; ++i)
        {
            var aIndex = a.Length - i - 1;
            var bIndex = b.Length - i - 1;
            var aChar = aIndex >= 0 ? a[aIndex] : '0';
            var bChar = bIndex >= 0 ? b[bIndex] : '0';

            stack.Push((char)(aChar ^ bChar ^ carryBit ^ '0'));
            carryBit = (aChar & bChar | aChar & carryBit | bChar & carryBit) ^ '0';
        }

        if(carryBit == 1)
            stack.Push('1');
        return new string(stack.ToArray());
    }
}