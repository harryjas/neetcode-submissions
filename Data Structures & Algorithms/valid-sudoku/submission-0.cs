public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int n = 9;
        HashSet<int>[] cols = new HashSet<int>[n];
        HashSet<int>[] rows = new HashSet<int>[n];
        HashSet<int>[] boxes = new HashSet<int>[n];

        for(int i =0;i<n;i++){
            cols[i] = new HashSet<int>();
            rows[i] = new HashSet<int>();
            boxes[i] = new HashSet<int>();
        }

        for(int i =0;i<n;i++){
            for(int j =0;j<n;j++){
                if(board[i][j] == '.'){
                    continue;
                }
                int num = (int)(board[i][j]);
                int box = (i/3) + (j/3)*3;
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
