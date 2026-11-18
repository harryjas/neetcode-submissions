public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length;
        List<List<int>> ans = new();
        for (int i = 0; i < n - 2; i++) {
            int target = -nums[i];
            int l = i + 1;
            int r = n - 1;
            while (l < r) {
                if (nums[l] + nums[r] == target) {
                    ans.Add(new List<int> { nums[i], nums[l], nums[r] });
                    while (l < r && nums[l + 1] == nums[l]) {
                        l++;
                    }
                    while (l < r && nums[r - 1] == nums[r]) {
                        r--;
                    }
                    l++;
                    r--;
                } else if (nums[l] + nums[r] < target) {
                    l++;
                } else {
                    r--;
                }
            }
            while (i + 1 < n && nums[i] == nums[i + 1]) {
                i++;
            }
        }
        return ans;
    }
}
