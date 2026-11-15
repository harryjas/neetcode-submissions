public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] mp = new int[26];
        foreach(char c in s){
            mp[c-'a']++;
        }
        foreach(char c in t){
            mp[c-'a']--;
        }
        foreach(int i in mp){
            if(i != 0){
                return false;
            }
        }
        return true;
    }
}
