public class Solution 
{
    public int[] PlusOne(int[] digits) 
    {
        var stack = new Stack<int>();
        bool hasCarry = true;

        for(int i = digits.Length - 1; i >= 0; --i)
        {
            if(hasCarry)
            {
                ++digits[i];
                hasCarry = false;
            }

            if(digits[i] == 10)
            {
                digits[i] = 0;
                hasCarry = true;
            }
            stack.Push(digits[i]);
        }
        if(hasCarry)
            stack.Push(1);
        return stack.ToArray();
    }
}