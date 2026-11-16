public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int n = 9;
        int sqrt = (int)Math.Sqrt(n);
        HashSet<char>[] cols = new HashSet<char>[n];
        HashSet<char>[] rows = new HashSet<char>[n];
        HashSet<char>[] boxes = new HashSet<char>[n];

        for(int i =0;i<n;i++){
            cols[i] = new HashSet<char>();
            rows[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for(int i =0;i<n;i++){
            for(int j =0;j<n;j++){
                if(board[i][j] == '.'){
                    continue;
                }
                char num = board[i][j];
                int box = (i/sqrt) + (j/sqrt)*sqrt;
                if(cols[i].Contains(num) || rows[j].Contains(num) || boxes[box].Contains(num))
                    return false;
                cols[i].Add(num);
                rows[j].Add(num);
                boxes[box].Add(num);
            }
        }
        return true;
    }
}
