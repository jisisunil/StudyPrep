public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        List<List<int>> result= new List<List<int>>();
        List<int> current = new List<int>();
        Array.Sort(candidates);
        CombinationSum2(candidates, target, 0, current, result);
        return result;
    }

    private void CombinationSum2(int[] candidates, int target, int start,  List<int> current,List<List<int>> result)
    {
        if(target==0)
        {
            result.Add(new List<int>(current));
            return;
        }
        if(target<0)
        {
            return;
        }

        for(int i=start;i<candidates.Length;i++)
        {
            if(i>start && candidates[i]==candidates[i-1])
            {
                continue;
            }
            if(target<candidates[i]) break;
            current.Add(candidates[i]);
            CombinationSum2(candidates, target-candidates[i], i+1, current, result);
            current.RemoveAt(current.Count-1);
        }
    }
}
