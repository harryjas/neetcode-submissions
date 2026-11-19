public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int[] left = new int[n];
        int[] right = new int[n];
        left[0] = height[0];
        right[n-1] = height[n-1];
        for(int i = 1;i<n;i++){
            left[i] = Math.Max(height[i], left[i-1]);
            right[n-i-1] = Math.Max(height[n-i-1], right[n-i]);
        }
        int ans = 0;
        for(int i =1;i<n-1;i++){
            if(height[i] >= left[i] && height[i]>=right[i]){
                continue;
            }
            ans += Math.Min(left[i],right[i]) - height[i];
        }
        return ans;
    }
}
