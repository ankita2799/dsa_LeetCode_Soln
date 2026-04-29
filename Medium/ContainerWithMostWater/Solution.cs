public class Solution
{
    public int MostWater(int[] heights)
    {
        int left = 0;int right = heights.Length-1;
        int maxVolume = 0;

        while (left < right) {
            int w = right - left;
            int h = Math.Min(heights[left], heights[right]);
            int area = w * h;
            if (area > maxVolume) {
                maxVolume = area;
             }
            heights[left] > heights[right] ? right-- : left++;
        }
        return maxVolume;
    }
}