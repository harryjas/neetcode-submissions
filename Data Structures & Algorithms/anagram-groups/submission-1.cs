public class Solution {
    static int[] mp = new int[26];
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> mp = new();
        foreach(string s in strs){
            string key = SortedString(s);
            if(!mp.ContainsKey(key)){
                mp[key] = new List<string>();
            }
            mp[key].Add(s);
        }
        return new List<List<string>>(mp.Values);
    }

    private string SortedString(string s){
        StringBuilder sb = new();
        foreach(char c in s){
            mp[c-'a']++;
        }
        for(int i =0;i<26;i++){
            if(mp[i] !=0){
                sb.Append('a'+i);
                sb.Append(mp[i]);
                sb.Append('#');
            }
            mp[i] = 0;
        }
        return sb.ToString();
    }
}
