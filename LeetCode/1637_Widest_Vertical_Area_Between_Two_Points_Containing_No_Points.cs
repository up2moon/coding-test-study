public class Solution
{
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        var set = new SortedSet<int>();

        foreach (var point in points)
            set.Add(point[0]);

        var sortedX = set.ToArray();

        int diff;
        int max = 0;

        for (int i = 0; i < sortedX.Length - 1; ++i)
        {
            diff = sortedX[i + 1] - sortedX[i];
            if (diff > max)
                max = diff;
        }
        return max;
    }
}