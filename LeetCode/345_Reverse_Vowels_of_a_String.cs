public class Solution
{
    public string ReverseVowels(string s)
    {
        int start = 0;
        int end = s.Length - 1;
        var arr = s.ToCharArray();
        const string Vowels = "aeiouAEIOU";

        while (start < end)
        {
            while (Vowels.All(c => c != arr[start]) && start < end)
                ++start;
            while (Vowels.All(c => c != arr[end]) && end > start)
                --end;
            if (start >= end)
                return new string(arr);
            char temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            ++start;
            --end;
        }
        return new string(arr);
    }
}