public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new();
        int ans = 0;
        int curr = 0;
        foreach(int num in nums){
            set.Add(num);
        }
        foreach(int i in set){
            int num = i;
            if(set.Contains(num-1)){
                continue;
            }
            curr = 1;
            while(set.Contains(++num)){
                curr++;
            }
            ans = Math.Max(ans,curr);
        }
        return ans;
    }
}
