public class Solution {
    public void Solve(char[][] board) {
        int rows = board.Length;
        int cols = board[0].Length;
        for(int r=0;r<rows;r++)
        {
            if(board[r][0]=='O')
            {
                Capture(board,r,0);
            }

            if(board[r][cols-1]=='O')
            {
                Capture(board,r,cols-1);
            }
        }

        for(int c=0;c<cols-1;c++)
        {
            if(board[0][c]=='O')
            {
                Capture(board,0, c);
            }

            if(board[rows-1][c]=='O')
            {
                Capture(board,rows-1,c);
            }
        }

        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<cols;j++)
            {
                if(board[i][j]=='O')
                {
                    board[i][j] = 'X';
                }
                else if(board[i][j] == 'T')
                {
                    board[i][j] = 'O';
                }
            }
        }
        
    }

    private void Capture(char[][] board, int r, int c)
    {
        if(r<0||r>=board.Length||c<0||c>=board[0].Length||board[r][c]!='O')
        {
            return;
        }

        board[r][c]='T';
        Capture(board,r+1,c);
        Capture(board,r-1,c);
        Capture(board,r,c+1);
        Capture(board,r,c-1);
    }
}
