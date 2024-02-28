public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var dict = new Dictionary<int, (int count, int count2)>();

        for (int i = 0; i < nums1.Length; ++i)
        {
            if (!dict.ContainsKey(nums1[i]))
                dict[nums1[i]] = (0, 0);
            dict[nums1[i]] = (dict[nums1[i]].count + 1, dict[nums1[i]].count2);
        }

        for (int i = 0; i < nums2.Length; ++i)
        {
            if (!dict.ContainsKey(nums2[i]))
                dict[nums2[i]] = (0, 0);
            dict[nums2[i]] = (dict[nums2[i]].count, dict[nums2[i]].count2 + 1);
        }

        var list = new List<int>();

        foreach (var kvp in dict)
        {
            var intersected = Math.Min(kvp.Value.count, kvp.Value.count2);

            if (intersected > 0)
            {
                for (int i = 0; i < intersected; ++i)
                    list.Add(kvp.Key);
            }
        }
        return list.ToArray();
    }
}