public class Solution {
    public bool IsPalindrome(string s) {
        int n = s.Length;
        s = s.ToLower();
        int l=0;
        int r = n-1;
        while(l<r){
            while(l<r && !IsValid(s[l])){
                l++;
            }
            while(l<r && !IsValid(s[r])){
                r--;
            }
            if(s[l] != s[r]){
                return false;
            }
            l++;
            r--;
        }
        return true;
    }

    private bool IsValid(char c){
        return ((c >= 'a' && c<='z') || (c>='0' && c<='9'));
    }
}
