public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> ans = new();
        int n = strs.Length;
        bool[] visited = new bool[n];
        for(int i =0;i<n;i++){
            if(visited[i]){
                continue;
            }
            List<string> ls = new();
            string s1 = strs[i];
            ls.Add(s1);
            for(int j = i+1;j<n;j++){
                string s2 = strs[j];
                if(s1.Length == s2.Length && isAnagram(s1,s2)){
                    ls.Add(s2);
                    visited[j] = true;
                }
            }
            visited[i] = true;
            ans.Add(ls);
        }
        return ans;
    }

    private bool isAnagram(string s1, string s2){
        int[] mp = new int[26];
        foreach(char c in s1){
            mp[c-'a']++;
        }
        foreach(char c in s2){
            mp[c-'a']--;
        }
        foreach(int i in mp){
            if(i !=0){
                return false;
            }
        }
        return true;
    }
}
