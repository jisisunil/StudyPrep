public class Solution {
    public int IslandPerimeter(int[][] grid) {
        
        int perimeter=0;
        for(int r=0;r<grid.Length;r++)
        {
            for(int c=0;c<grid[0].Length;c++)
            {
                if(grid[r][c]==1)
                {
                    perimeter+=4;

                    if(r>0  && grid[r-1][c]==1)
                    {
                        perimeter-=2;
                    }

                    if(c>0 && grid[r][c-1]==1)
                    {
                        perimeter-=2;
                    }

                }
            }
        }
        return perimeter;
    }
}