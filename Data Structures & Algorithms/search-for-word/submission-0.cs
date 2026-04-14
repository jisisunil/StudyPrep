public class Solution {
    public bool Exist(char[][] board, string word) {
        int rows= board.Length;
        int cols = board[0].Length;

        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<cols;j++)
            {
                if(dfs(board, i,j,0, word))
                return true;
            }
        }
        return false;
    }

    private bool dfs(char[][] board, int row, int col, int index, string word)
    {
        if(index==word.Length)
        {
            return true;
        }

        if(row<0||row>=board.Length || col <0 || col>=board[0].Length || word[index]!=board[row][col])
        {
            return false;
        }
        char temp = board[row][col];
        board[row][col]='#';

        bool found = dfs(board, row+1,col, index+1,word) || 
                        dfs(board, row-1,col, index+1,word)||
                        dfs(board, row,col+1, index+1,word)||
                        dfs(board, row,col-1, index+1,word);
            board[row][col]=temp;
        return found;
    }
}
