public class Solution 
{
    public string AddBinary(string a, string b) 
    {
        var stack = new Stack<char>();
        int carryBit = 0;

        for(int i = 0; i < Math.Max(a.Length, b.Length); ++i)
        {
            var aIndex = a.Length - i - 1;
            var bIndex = b.Length - i - 1;
            var aNum = aIndex >= 0 ? a[aIndex] ^ '0' : 0;
            var bNum = bIndex >= 0 ? b[bIndex] ^ '0' : 0;

            stack.Push((char)(aNum ^ bNum ^ carryBit ^ '0'));
            carryBit = aNum & bNum | aNum & carryBit | bNum & carryBit;
        }

        if(carryBit == 1)
            stack.Push((char)(carryBit ^ '0'));
        return new string(stack.ToArray());
    }
}