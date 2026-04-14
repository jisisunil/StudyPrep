public class Solution {
    public string SimplifyPath(string path) {

        string[] components = path.Split('/');
        Stack<string> stk= new Stack<string>();
        foreach(var component in components)
        {
            if(component=="" || component==".")
            {
                continue;
            }
            else if(component=="..")
            {
                if(stk.Count>0)
                {
                    stk.Pop();
                } 
            }
            else
            {
                stk.Push(component);
            }
        }

        if(stk.Count==0)
        {
            return "/";
        }

        return "/"+string.Join("/", stk.Reverse());
        
    }
}