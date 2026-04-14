public class Solution {
    public bool IsPathCrossing(string path) {
        HashSet<string> visited = new HashSet<string>();

        int x=0;
        int y=0;

        visited.Add($"{x},{y}");

        foreach(var c in path)
        {
            if(c== 'N')
            {
                y++;
            }
            else if(c=='S') y--;
            else if(c == 'E') x++;
            else if(c == 'W') x--;

            if(visited.Contains($"{x},{y}")) return true;
            visited.Add($"{x},{y}");
        }
        return false;
        
    }
}