public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        int[] result = new int[2];
        //Array.Sort(nums);

        if (nums.Length >= 2)
        {
            for (int i = 0; i < nums.Length; i++)
            {

                if (nums.Contains(target - nums[i]))
                {
                    result[0] = i;
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if ((target - nums[i]) == nums[j])
                        {
                            result[1] = j;
                            return result;
                        }
                    }
                }
            }
        }
        return result;
    }
}