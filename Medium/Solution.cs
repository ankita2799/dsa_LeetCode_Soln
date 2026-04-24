public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var answer = new int[nums.Length];

        var result = 1;
        for (var i = 0; i < nums.Length; i++)
        {
            answer[i] = result;
            result = result * nums[i];
        }

        result = 1;
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] = answer[i] * nums[i];
            result = result * nums[i];
        }

        return answer;
    }
}