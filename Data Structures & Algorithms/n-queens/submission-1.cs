public class Solution {
            bool[] cols;
        bool[] posDiag ;
        bool[] negDiag;
    public List<List<string>> SolveNQueens(int n) {

        cols=new bool[n];
        posDiag = new bool[2*n-1];
        negDiag = new bool[2*n-1];

        char[][] board = new char[n][];
        List<List<string>> result= new List<List<string>>();
        for(int i=0;i<n;i++)
        {
            board[i]= new char[n];

            Array.Fill(board[i],'.');
        }

        backtrack(board, 0, n, result);

        return result;
    }


    private void backtrack(char[][] board, int r, int n, List<List<string>> result)
    {

        if(r==n)
        {
            var res = new List<string>();
            foreach(var row in board)
            {
                res.Add(new string(row));
            }
            result.Add(res);
            return;
        }
        for(int c=0;c<n;c++)
        {
            if(cols[c]|| posDiag[r+c]||negDiag[r-c+(n-1)])
            {
                continue;
            }

            cols[c]=true;
            posDiag[r+c]=true;
            negDiag[r-c+(n-1)]=true;
            board[r][c]='Q';
            backtrack(board, r+1, n, result);
            cols[c]=false;
            posDiag[r+c]=false;
             negDiag[r-c+(n-1)]=false;
            board[r][c]='.';
        }

    }
}
