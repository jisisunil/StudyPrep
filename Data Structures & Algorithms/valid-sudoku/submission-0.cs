public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
     HashSet<char>[] rowset = new HashSet<char>[9];
     HashSet<char>[] colset = new HashSet<char>[9];
     HashSet<char>[] boxset = new HashSet<char>[9];
     for(int i=0;i<9;i++)
     {
        rowset[i] = new HashSet<char>();
        colset[i] = new HashSet<char>();
        boxset[i] = new HashSet<char>();
     }
     for(int i=0;i<board.Length;i++)
     {

        for(int j=0;j<board[0].Length;j++)
        {
            if(board[i][j]=='.')
            {
                continue;
            }
            int boxindex=(i/3)*3+j/3;
            if(rowset[i].Contains(board[i][j])|| colset[j].Contains(board[i][j])||boxset[boxindex].Contains(board[i][j]))
            {
                return false;
            }
            rowset[i].Add(board[i][j]);
            colset[j].Add(board[i][j]);
            boxset[boxindex].Add(board[i][j]);
        }
       
     }
 return true;
    }
}
