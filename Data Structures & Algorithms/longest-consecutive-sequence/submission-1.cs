public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new();
        int ans = 0;
        int curr = 0;
        foreach(int num in nums){
            set.Add(num);
        }
        for(int i =0;i<nums.Length;i++){
            int num = nums[i];
            if(set.Contains(num-1)){
                continue;
            }
            curr = 1;
            while(set.Contains(++num)){
                curr++;
            }
            ans = Math.Max(ans,curr);
        }
        return Math.Max(ans,curr);
    }
}
