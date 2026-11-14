public class Solution {
    public int LongestConsecutive(int[] nums) {
        int n = nums.Length;
        if(n == 0 || n ==1){
            return n;
        }
        Array.Sort(nums);
        int ans = 1;
        int max = 1;
        for(int i = 1; i <n;i++){
            if (nums[i] == nums[i - 1]) {
                continue;
            }
            if(nums[i] == nums[i-1] + 1){
                max++;
            }else{
                ans = Math.Max(max, ans);
                max = 1;
            }
        }
        ans = Math.Max(max, ans);
        return ans;
    }
}
