namespace Leetcode;

public class RemoveDuplicatesFromSortedArray
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
}
