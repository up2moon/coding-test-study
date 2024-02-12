public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        IList<IList<int>> list = new List<IList<int>>();

        list.Add(new List<int>() { 1 });

        if (rowIndex == 0)
            return list[rowIndex];

        list.Add(new List<int>() { 1, 1 });

        for (int i = 2; i < rowIndex + 1; ++i)
        {
            var row = new List<int>();
            row.Add(1);
            for (int j = 1; j < i; ++j)
                row.Add(list[i - 1][j - 1] + list[i - 1][j]);
            row.Add(1);
            list.Add(row);
        }
        return list[rowIndex];
    }
}