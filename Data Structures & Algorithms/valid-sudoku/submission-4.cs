public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for(int i=0;i<9;i++)
        {
            rows[i]= new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for(int i=0;i<board.Length;i++)
        {
            for(int j=0;j<board[0].Length;j++)
            {
                char  c = board[i][j];
                if(c=='.') continue;

                int boxindex = (i/3)*3+(j/3);

                if(rows[i].Contains(c)||cols[j].Contains(c)||boxes[boxindex].Contains(c))
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
