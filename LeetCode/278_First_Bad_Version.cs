/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int first = 0;
        int last = n;

        while (first <= last)
        {
            int mid = (int)((uint)(first + last) / 2);

            if (IsBadVersion(mid))
                last = mid - 1;
            else
                first = mid + 1;
        }
        return first;
    }
}