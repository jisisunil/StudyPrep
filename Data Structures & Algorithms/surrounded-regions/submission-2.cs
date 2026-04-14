public class Solution {
    public void Solve(char[][] board) {

        int rows = board.Length;
        int cols = board[0].Length;
        for(int i=0;i<rows;i++)
        {
            CaptureBorderOs(board, i,0);
            CaptureBorderOs(board, i, cols-1);
            
        }

        for(int i=0;i<cols;i++)
        {
            CaptureBorderOs(board, 0,i);
            CaptureBorderOs(board, rows-1, i);
        }

        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<cols;j++)
            {
                if(board[i][j]=='O')
                {
                    board[i][j] = 'X';

                }
                if(board[i][j]=='T')
                {
                    board[i][j]='O';
                }
            }
        }
        
    }

    private void CaptureBorderOs(char[][] board, int r, int c)
    {
        if(r<0|| r>=board.Length || c<0||c>=board[0].Length || board[r][c]!='O')
        {
            return;
        }
        board[r][c]='T';
        CaptureBorderOs(board, r+1,c);
        CaptureBorderOs(board, r-1,c);
        CaptureBorderOs(board, r,c+1);
        CaptureBorderOs(board, r, c-1);
    }
}
