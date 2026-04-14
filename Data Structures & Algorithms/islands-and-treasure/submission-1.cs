public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        Queue<(int,int)> q = new Queue<(int,int)>();
        for(int i=0;i<grid.Length;i++)
        {
            for(int j=0;j<grid[0].Length;j++)
            {
                if(grid[i][j]==0)
                {
                    q.Enqueue((i,j));
                }
            }
        }
        if(q.Count==0) return;
        int[][] dirs = new int[4][]{ new int[]{1,0}, new int[] {-1,0}, new int[] {0,1}, new int[]{0,-1}};

        while(q.Count>0)
        {
            
            var pos = q.Dequeue();
            var row = pos.Item1;
            var col = pos.Item2;

            for(int i=0;i<dirs.Length;i++)
            {
                var newRow = row+dirs[i][0];
                var newCol = col+dirs[i][1];

                if(newRow<0||newRow>=grid.Length||newCol<0||newCol>=grid[0].Length||grid[newRow][newCol]!=int.MaxValue)
                {
                    continue;
                }
                q.Enqueue((newRow, newCol));
                grid[newRow][newCol]=grid[row][col]+1;
            }            
        }
        
    }
}
