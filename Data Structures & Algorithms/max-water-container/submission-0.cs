public class Solution {
    public int MaxArea(int[] heights) {
        int n = heights.Length;
        int l =0;
        int r = n-1;
        int ans = 0;
        while(l<r){
            ans = Math.Max(ans, (r-l)*Math.Min(heights[l],heights[r]));
            if(heights[r] < heights[l]){
                r--;
            }else{
                l++;
            }
        }
        return ans;
    }
}
