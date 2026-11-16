public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new();
        foreach(string str in strs){
            sb.Append(str.Length);
            sb.Append('#');
            sb.Append(str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<String> result = new();
        int i = 0;
        int n = s.Length;
        while(i < n){
            int j = i;
            while(s[j] != '#'){
                j++;
            }

            int l = Int32.Parse(s.Substring(i, j-i));
            string str = s.Substring(j+1, l);
            result.Add(str);
            i = j + l + 1;
        }
        return result;
   }
}
