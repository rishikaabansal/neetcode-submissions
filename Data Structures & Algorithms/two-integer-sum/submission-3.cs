public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> seen = new();
        int[] ans;

        for(int i=0; i<nums.Length; i++)
        {
            seen[nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (seen.ContainsKey(diff) && seen[diff] != i) 
            {
                return new int[]{i, seen[diff]};
            }
        }

        return new int[0];
    }
}
