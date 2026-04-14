public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int maxarea=0;
        for(int i=0;i<grid.Length;i++)
        {
            for(int j=0;j<grid[0].Length;j++)
            {
                if(grid[i][j]==1)
                {
                    int area = dfs(grid, i,j);
                    maxarea = Math.Max(maxarea, area);

                }
            }
        }
        return maxarea;
        
    }

    private int dfs(int[][]grid, int r, int c)
    {
        if(r<0||r>=grid.Length || c<0 || c>=grid[0].Length|| grid[r][c]==0)
        {
            return 0;
        }

        grid[r][c]=0;

        return 1+ dfs(grid,r+1,c) + dfs(grid, r-1,c) + dfs(grid, r, c+1) + dfs(grid, r, c-1);
    }
}
