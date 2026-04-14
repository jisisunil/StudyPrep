public class Solution {
    public int OrangesRotting(int[][] grid) {
        int m = grid.Length;
        int n= grid[0].Length;
        Queue<(int,int)> q= new Queue<(int r,int c)>();
        int fresh =0;
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(grid[i][j]==2)
                {
                    q.Enqueue((i,j));//multi source bfs
                }
                else if(grid[i][j]==1)
                {
                    fresh++;
                }
            }
        }

        if(fresh==0) return 0;
        int minutes =-1;
        int[][] dirs = new int[4][] {new int[] {1,0}, new int[] {-1,0}, new int[] {0, 1}, new int[] {0, -1}};
        while(q.Count>0)
        {

            int levelSize = q.Count;

            for(int i=0;i<levelSize;i++)
            {            
                var (r,c) = q.Dequeue();

                foreach(var d in dirs)
                {
                    int nr = r+d[0];
                    int nc = c+d[1];

                    if(nr<0 || nr >= m|| nc<0||nc >=n||grid[nr][nc]!=1)
                    {
                        continue;
                    }
                    grid[nr][nc]=2;
                    fresh--;
                    q.Enqueue((nr,nc));
                }
            }
            minutes++;
        }
        return fresh==0?minutes:-1;
    }
}
