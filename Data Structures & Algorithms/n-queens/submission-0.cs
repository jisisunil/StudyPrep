public class Solution {
    bool[] cols;
    bool[] posDiag ;
    bool[] negDiag ;
    public List<List<string>> SolveNQueens(int n) {
        /*
        Since some results are negative, we shift by (n - 1) to make indices non-negative:

index = r - c + (n - 1)

Let’s fill those in for n = 4 (so shift by +3):

↙ Diagonal IDs (r - c + 3)
+---+---+---+---+
| 3 | 2 | 1 | 0 |
+---+---+---+---+
| 4 | 3 | 2 | 1 |
+---+---+---+---+
| 5 | 4 | 3 | 2 |
+---+---+---+---+
| 6 | 5 | 4 | 3 |
+---+---+---+---+


Smallest value = 0, largest = 6 → again 7 diagonals = 2×4 - 1*/
   cols = new bool[n];
   posDiag = new bool[2*n-1];
   negDiag = new bool[2*n-1];
    List<List<string>> result = new List<List<string>>();

    char[][] board = new char[n][];
    //Fill the board with '.'
    for(int i=0;i<n;i++)
    {
        board[i] = new char[n];
        Array.Fill(board[i], '.');
    }

    backtrack(board, 0, n, result);
    return result;

    }


    private void backtrack(char[][] board, int r, int n, List<List<string>> result)
    {
        if(r == n)
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

            if(cols[c]||posDiag[r+c]||negDiag[r-c+(n-1)]) // offset with n-1 so that we can make indeces non-ve
            { 
                continue;
            }
             cols[c]=true;
             posDiag[r+c] = true;
             negDiag[r-c+(n-1)] = true;
             board[r][c] ='Q';
             backtrack(board, r+1,n, result);
             cols[c] = false;
             posDiag[r+c] = false;
             negDiag[r-c+(n-1)] = false;

             board[r][c]='.';
        }
    }
}
