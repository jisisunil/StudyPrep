public class Solution {
    public bool IsValidSudoku(char[][] board) {

        if (board == null || board.Length != 9) return false;
        int n = 9;
        
        HashSet<char>[] rows = new HashSet<char>[n];
        HashSet<char>[] cols = new HashSet<char>[n];
        HashSet<char>[] boxes = new HashSet<char>[n];

        for(int i=0;i<n;i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                char c = board[i][j];
                if(c=='.') continue;
                int boxindex = (i / 3) * 3 + (j/3);
                if(rows[i].Contains(c) || cols[j].Contains(c)||boxes[boxindex].Contains(c))
                {
                    return false;
                }
                rows[i].Add(c);
                cols[j].Add(c);
                boxes[boxindex].Add(c);
            }
        }
        return true;
    }  
}
