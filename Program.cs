// See https://aka.ms/new-console-template for more information
/*public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var setNums = new SortedSet<int>(nums).ToArray();
        for (int i = 0; i < setNums.Length; i++)
        {
            nums[i] = setNums[i];
        }
        return setNums.Length;
    }
}*/

/*public class Solution
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
}*/