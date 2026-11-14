public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> mp = new();
        int pos = 0;
        foreach(int i in nums){
            if(mp.ContainsKey(target - i)){
                return new int[]{mp[target-i],pos};
            }else{
                mp[i] = pos;
            }
            pos++;
        }
        return new int[0];
    }
}
