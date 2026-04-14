public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) {
        int rows= heights.Length;
        int cols=  heights[0].Length;
        bool[,] pacific = new bool[rows,cols];
        bool[,] atlantic = new bool[rows,cols];

        List<List<int>> result= new List<List<int>>();

        
        for(int i=0;i<rows;i++)
        {
            dfs(heights, i, 0, pacific, heights[i][0]);
            dfs(heights, i, cols-1, atlantic, heights[i][cols-1]);
        }

        for(int j=0;j<cols;j++)
        {
            dfs(heights, 0, j, pacific, heights[0][j]);
            dfs(heights, rows-1, j, atlantic, heights[rows-1][j]);

        }

        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<cols;j++)
            {
                if(pacific[i,j] && atlantic[i,j])
                {
                    result.Add(new List<int>{i,j});
                }
            }
        }
        return result;
    }

    private void dfs(int[][] heights, int row, int col, bool[,] visited,int prevHeight)
    {

        if(row<0||row>=heights.Length||col<0||col>=heights[0].Length||visited[row,col] || heights[row][col]<prevHeight)
        {
            return;
        }
        visited[row,col]=true;
        dfs(heights, row+1, col, visited,  heights[row][col]);
        dfs(heights, row-1,col, visited,  heights[row][col]);
        dfs(heights, row, col+1, visited,  heights[row][col]);
        dfs(heights, row, col-1, visited,  heights[row][col]);
    }

}
