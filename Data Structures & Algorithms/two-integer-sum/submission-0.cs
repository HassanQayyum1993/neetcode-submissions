public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (dictionary.ContainsKey(complement))
            {
                return new int[] { dictionary[complement], i };
            }

            dictionary[nums[i]] = i;
        }

        return new int[0];
    }
}
