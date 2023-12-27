namespace Leetcode;

public class SummaryRangesLeetcode
{
    public IList<string> SummaryRanges(int[] nums)
    {
        var startIndex = 0;
        var list = new List<string>();

        while (startIndex < nums.Length)
        {
            int start = nums[startIndex];
            int end = nums[startIndex];

            while (startIndex < nums.Length - 1 && (nums[startIndex + 1] - nums[startIndex] == 1))
            {
                end = nums[startIndex + 1];
                startIndex++;
            }

            if (start == end)
                list.Add(start.ToString());
            else
                list.Add($"{start}->{end}");
            startIndex++;
        }
        return list;
    }
}
