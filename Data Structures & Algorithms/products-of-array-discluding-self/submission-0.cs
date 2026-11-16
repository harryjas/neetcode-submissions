public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] n1 = new int[n];
        int[] n2 = new int[n];
        n1[0] = nums[0];
        n2[n-1] = nums[n-1];
        for(int i =1;i<n;i++){
            n1[i] = nums[i] * n1[i-1];
            n2[n-i-1] = nums[n-i-1] * n2[n-i];
        }
        int[] ans = new int[n];
        for(int i =0;i<n;i++){
            ans[i] = (i-1>=0 ? n1[i-1] : 1) * (i+1 <n ? n2[i+1] : 1);
        }
        return ans;
    }
}
